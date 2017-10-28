﻿using BehaviorDesigner.Runtime;
using System.Collections.Generic;
using UnityEngine;

namespace AI.Runtime
{
    
    public class AIRuntimeUtil
    {
        static string Children = "Children";

        public static AIRuntimeTreeData Load(string name)
        {
            TextAsset ta = XResources.Load<TextAsset>("AITree/" + name, AssetType.Text);
            return Parse(ta.text, name);
        }

        private static AIRuntimeTreeData Parse(string json, string name)
        {
            XDebug.Log(json);
            var obj = MiniJSON.Deserialize(json) as Dictionary<string, object>;
            var root = obj as Dictionary<string, object>;
            var dic_task = root["RootTask"] as Dictionary<string, object>;
            AIRuntimeTaskData task = ParseTask(dic_task);
            AIRuntimeTreeData tree = new AIRuntimeTreeData();
            tree.task = task;
            if (root.ContainsKey("Variables"))
            {
                var list = root["Variables"] as List<object>;
                for (int i = 0, max = list.Count; i < max; i++)
                {
                    AITreeVar v = ParseTreeVar(list[i] as Dictionary<string, object>);
                    tree.vars.Add(v);
                }
            }
            return tree;
        }


        private static AITreeVar ParseTreeVar(Dictionary<string, object> arg)
        {
            return new AITreeVar()
            {
                isShared = bool.Parse(arg["IsShared"].ToString()),
                type = arg["Type"].ToString(),
                name = arg["Name"].ToString()
            };
        }

        private static AIRuntimeTaskData ParseTask(Dictionary<string, object> arg)
        {
            AIRuntimeTaskData t = new AIRuntimeTaskData();
            t.name = arg["Name"].ToString();
            var type = arg["Type"].ToString();
            t.type = ParseType(type);
            foreach (var item in arg)
            {
                if (item.Key.StartsWith("Shared"))
                {
                    AIShareVar v = ParseVar(item.Key, item.Value as Dictionary<string, object>);
                    if (t.vars == null) t.vars = new List<AIShareVar>();
                    t.vars.Add(v);
                }
            }
            if (arg.ContainsKey(Children))
            {
                List<object> list = arg[Children] as List<object>;
                for (int i = 0, max = list.Count; i < max; i++)
                {
                    Dictionary<string, object> child = list[i] as Dictionary<string, object>;
                    if (t.children == null) t.children = new List<AIRuntimeTaskData>();
                    AIRuntimeTaskData tt = ParseTask(child);
                    t.children.Add(tt);
                }
            }
            return t;
        }


        private static AIShareVar ParseVar(string key, Dictionary<string, object> dic)
        {
            AIShareVar v = new AIShareVar();
            v.name = key;
            v.type = ParseType(dic["Type"].ToString());
            foreach (var item in dic)
            {
                if (item.Key.Contains("Value"))
                {
                    v.val = item.Value;
                    break;
                }
            }
            return v;
        }


        private static string ParseType(string str)
        {
            int index = str.LastIndexOf(".");
            return index == -1 ? str : str.Substring(index + 1);
        }
    }

}