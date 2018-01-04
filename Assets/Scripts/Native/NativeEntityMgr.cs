﻿using System.Collections.Generic;

public class NativeEntityMgr :XSingleton<NativeEntityMgr>
{

    Dictionary<uint, NativeEntity> dic = new Dictionary<uint, NativeEntity>();

    public bool Add<T>(uint uid, uint presentid) where T : NativeEntity, new()
    {
        if (!dic.ContainsKey(uid))
        {
            T ent = new T();
            ent.Load(uid, presentid);
            dic.Add(uid, ent);
            return true;
        }
        return false;
    }

    public void Update(float delta)
    {
        var e = dic.GetEnumerator();
        while(e.MoveNext())
        {
            e.Current.Value.Update(delta);
        }
    }

    public bool Remv(uint uid)
    {
        if(dic.ContainsKey(uid))
        {
            dic[uid].Unload();
            return true;
        }
        return false;
    }

    public NativeEntity Get(uint uid)
    {
        if(dic.ContainsKey(uid))
        {
            return dic[uid];
        }
        return null;
    }

}