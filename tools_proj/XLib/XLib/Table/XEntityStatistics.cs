//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8784
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTable {
    
    
    public class XEntityStatistics : CVSReader {
        
        public class RowData :BaseRow {
			public int UID;
			public string Name;
			public uint PresentID;
			public int Type;
			public string Tag;
			public int Fightgroup;
			public string SummonGroup;
			public float WalkSpeed;
			public float RunSpeed;
			public float[] FloatHeight;
			public float RotateSpeed;
			public int AttackSpeed;
			public int SkillCD;
			public float AttackProb;
			public float Sight;
			public float FightTogetherDis;
			public string BeLocked;
			public string InBornBuff;
			public string MaxSuperArmor;
			public bool WeakStatus;
			public string SuperArmorBrokenBuff;
			public int SuperArmorRecoveryValue;
			public int SuperArmorRecoveryMax;
			public int AttackBase;
			public int MagicAttackBase;
			public float MaxHP;
			public int MobaExp;
			public int MobaExpRange;
			public bool MobaKillNeedHint;
			public int PosIndex;
			public int HpSection;
			public bool IsWander;
			public bool Block;
			public bool DynamicBlock;
			public bool UsingGeneralCutscene;
			public bool SoloShow;
			public bool EndShow;
			public int Fov;
			public float AIStartTime;
			public float AIActionGap;
			public bool IsFixedInCD;
			public int FashionTemplate;
			public bool Highlight;
			public string UseMyMesh;
			public string ExtraReward;
			public int aihit;
			public string AiBehavior;
			public int InitEnmity;
			public bool AlwaysHpBar;
			public bool HideName;
			public float ratioleft;
			public float ratioright;
			public float ratioidle;
			public float ratiodistance;
			public float ratioskill;
			public float ratioexp;
			public string navigation;
			public int IsNavPingpong;
			public bool HideInMiniMap;
			public string Access;
			public string SameBillBoard;
			public string PandoraDropIDs;
			public string DropIDs;
			public string BigMeleePoints;
		}


		private RowData[] Table;

		public override int length { get { return Table.Length; } }

		public RowData this[int index] { get { return Table[index]; } }

		public override string bytePath { get { return "Table/XEntityStatistics"; } }
        
        // 二分法查找
        public virtual RowData GetByUID(int id) {
			return BinarySearch(Table, 0, Table.Length - 1, id) as RowData;
        }
        
        public override void OnClear(int lineCount) {
			if (lineCount > 0) Table = new RowData[lineCount];
			else Table = null;
        }
        
        public override void ReadLine(System.IO.BinaryReader reader) {
			RowData row = new RowData();
			Read<int>(reader, ref row.UID, intParse); columnno = 0;
			Read<string>(reader, ref row.Name, stringParse); columnno = 1;
			Read<uint>(reader, ref row.PresentID, uintParse); columnno = 2;
			Read<int>(reader, ref row.Type, intParse); columnno = 3;
			Read<string>(reader, ref row.Tag, stringParse); columnno = 4;
			Read<int>(reader, ref row.Fightgroup, intParse); columnno = 5;
			Read<string>(reader, ref row.SummonGroup, stringParse); columnno = 6;
			Read<float>(reader, ref row.WalkSpeed, floatParse); columnno = 7;
			Read<float>(reader, ref row.RunSpeed, floatParse); columnno = 8;
			ReadArray<float>(reader, ref row.FloatHeight, floatParse); columnno = 9;
			Read<float>(reader, ref row.RotateSpeed, floatParse); columnno = 10;
			Read<int>(reader, ref row.AttackSpeed, intParse); columnno = 11;
			Read<int>(reader, ref row.SkillCD, intParse); columnno = 12;
			Read<float>(reader, ref row.AttackProb, floatParse); columnno = 13;
			Read<float>(reader, ref row.Sight, floatParse); columnno = 14;
			Read<float>(reader, ref row.FightTogetherDis, floatParse); columnno = 15;
			Read<string>(reader, ref row.BeLocked, stringParse); columnno = 16;
			Read<string>(reader, ref row.InBornBuff, stringParse); columnno = 17;
			Read<string>(reader, ref row.MaxSuperArmor, stringParse); columnno = 18;
			Read<bool>(reader, ref row.WeakStatus, boolParse); columnno = 19;
			Read<string>(reader, ref row.SuperArmorBrokenBuff, stringParse); columnno = 20;
			Read<int>(reader, ref row.SuperArmorRecoveryValue, intParse); columnno = 21;
			Read<int>(reader, ref row.SuperArmorRecoveryMax, intParse); columnno = 22;
			Read<int>(reader, ref row.AttackBase, intParse); columnno = 23;
			Read<int>(reader, ref row.MagicAttackBase, intParse); columnno = 24;
			Read<float>(reader, ref row.MaxHP, floatParse); columnno = 25;
			Read<int>(reader, ref row.MobaExp, intParse); columnno = 26;
			Read<int>(reader, ref row.MobaExpRange, intParse); columnno = 27;
			Read<bool>(reader, ref row.MobaKillNeedHint, boolParse); columnno = 28;
			Read<int>(reader, ref row.PosIndex, intParse); columnno = 29;
			Read<int>(reader, ref row.HpSection, intParse); columnno = 30;
			Read<bool>(reader, ref row.IsWander, boolParse); columnno = 31;
			Read<bool>(reader, ref row.Block, boolParse); columnno = 32;
			Read<bool>(reader, ref row.DynamicBlock, boolParse); columnno = 33;
			Read<bool>(reader, ref row.UsingGeneralCutscene, boolParse); columnno = 34;
			Read<bool>(reader, ref row.SoloShow, boolParse); columnno = 35;
			Read<bool>(reader, ref row.EndShow, boolParse); columnno = 36;
			Read<int>(reader, ref row.Fov, intParse); columnno = 37;
			Read<float>(reader, ref row.AIStartTime, floatParse); columnno = 38;
			Read<float>(reader, ref row.AIActionGap, floatParse); columnno = 39;
			Read<bool>(reader, ref row.IsFixedInCD, boolParse); columnno = 40;
			Read<int>(reader, ref row.FashionTemplate, intParse); columnno = 41;
			Read<bool>(reader, ref row.Highlight, boolParse); columnno = 42;
			Read<string>(reader, ref row.UseMyMesh, stringParse); columnno = 43;
			Read<string>(reader, ref row.ExtraReward, stringParse); columnno = 44;
			Read<int>(reader, ref row.aihit, intParse); columnno = 45;
			Read<string>(reader, ref row.AiBehavior, stringParse); columnno = 46;
			Read<int>(reader, ref row.InitEnmity, intParse); columnno = 47;
			Read<bool>(reader, ref row.AlwaysHpBar, boolParse); columnno = 48;
			Read<bool>(reader, ref row.HideName, boolParse); columnno = 49;
			Read<float>(reader, ref row.ratioleft, floatParse); columnno = 50;
			Read<float>(reader, ref row.ratioright, floatParse); columnno = 51;
			Read<float>(reader, ref row.ratioidle, floatParse); columnno = 52;
			Read<float>(reader, ref row.ratiodistance, floatParse); columnno = 53;
			Read<float>(reader, ref row.ratioskill, floatParse); columnno = 54;
			Read<float>(reader, ref row.ratioexp, floatParse); columnno = 55;
			Read<string>(reader, ref row.navigation, stringParse); columnno = 56;
			Read<int>(reader, ref row.IsNavPingpong, intParse); columnno = 57;
			Read<bool>(reader, ref row.HideInMiniMap, boolParse); columnno = 58;
			Read<string>(reader, ref row.Access, stringParse); columnno = 59;
			Read<string>(reader, ref row.SameBillBoard, stringParse); columnno = 60;
			Read<string>(reader, ref row.PandoraDropIDs, stringParse); columnno = 61;
			Read<string>(reader, ref row.DropIDs, stringParse); columnno = 62;
			Read<string>(reader, ref row.BigMeleePoints, stringParse); columnno = 63;
			row.sortID = (int)row.UID;
			Table[lineno] = row;
			columnno = -1;
        }
    }
}
