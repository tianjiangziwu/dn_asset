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
    
    
    public class XEntityPresentation : CVSReader {
        
        public class RowData :BaseRow {
			public uint UID;
			public string Prefab;
			public string Name;
			public string BoneSuffix;
			public string AnimLocation;
			public string SkillLocation;
			public string CurveLocation;
			public float BoundRadius;
			public float[] BoundRadiusOffset;
			public float BoundHeight;
			public string HugeMonsterColliders;
			public float Scale;
			public string UIAvatarAngle;
			public float UIAvatarScale;
			public string AvatarPos;
			public bool Huge;
			public string EnterGame;
			public int AngluarSpeed;
			public string Idle;
			public string AttackIdle;
			public string FishingIdle;
			public string Walk;
			public string AttackWalk;
			public string Run;
			public string AttackRun;
			public string RunLeft;
			public string AttackRunLeft;
			public string RunRight;
			public string AttackRunRight;
			public string MoveFx;
			public string Freeze;
			public string FreezeFx;
			public string[] Hit_f;
			public string[] Hit_l;
			public string[] Hit_r;
			public float[] HitBackOffsetTimeScale;
			public string[] HitFly;
			public float[] HitFlyOffsetTimeScale;
			public string[] Hit_Roll;
			public float[] HitRollOffsetTimeScale;
			public float[] HitBack_Recover;
			public float[] HitFly_Bounce_GetUp;
			public float HitRoll_Recover;
			public string HitFx;
			public string Death;
			public string DeathFx;
			public string[] HitCurves;
			public string DeathCurve;
			public string A;
			public string AA;
			public string AAA;
			public string AAAA;
			public string AAAAA;
			public string OtherSkills;
			public string SkillNum;
			public string Dash;
			public string Ultra;
			public string Appear;
			public string Disappear;
			public string FishingCast;
			public string FishingPull;
			public string FishingWait;
			public string FishingWin;
			public string FishingLose;
			public string Dance;
			public string Kiss;
			public string InheritActionOne;
			public string InheritActionTwo;
			public string Atlas;
			public string Avatar;
			public string Atlas2;
			public string Avatar2;
			public bool Shadow;
			public string Feeble;
			public string FeebleFx;
			public string ArmorBroken;
			public string SuperArmorRecoverySkill;
			public string RecoveryFX;
			public string RecoveryHitSlowFX;
			public string RecoveryHitStopFX;
		}


		private RowData[] Table;

		public override int length { get { return Table.Length; } }

		public RowData this[int index] { get { return Table[index]; } }

		public override string bytePath { get { return "Table/XEntityPresentation"; } }
        
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
			Read<uint>(reader, ref row.UID, uintParse); columnno = 0;
			Read<string>(reader, ref row.Prefab, stringParse); columnno = 1;
			Read<string>(reader, ref row.Name, stringParse); columnno = 2;
			Read<string>(reader, ref row.BoneSuffix, stringParse); columnno = 3;
			Read<string>(reader, ref row.AnimLocation, stringParse); columnno = 4;
			Read<string>(reader, ref row.SkillLocation, stringParse); columnno = 5;
			Read<string>(reader, ref row.CurveLocation, stringParse); columnno = 6;
			Read<float>(reader, ref row.BoundRadius, floatParse); columnno = 7;
			ReadArray<float>(reader, ref row.BoundRadiusOffset, floatParse); columnno = 8;
			Read<float>(reader, ref row.BoundHeight, floatParse); columnno = 9;
			Read<string>(reader, ref row.HugeMonsterColliders, stringParse); columnno = 10;
			Read<float>(reader, ref row.Scale, floatParse); columnno = 11;
			Read<string>(reader, ref row.UIAvatarAngle, stringParse); columnno = 12;
			Read<float>(reader, ref row.UIAvatarScale, floatParse); columnno = 13;
			Read<string>(reader, ref row.AvatarPos, stringParse); columnno = 14;
			Read<bool>(reader, ref row.Huge, boolParse); columnno = 15;
			Read<string>(reader, ref row.EnterGame, stringParse); columnno = 16;
			Read<int>(reader, ref row.AngluarSpeed, intParse); columnno = 17;
			Read<string>(reader, ref row.Idle, stringParse); columnno = 18;
			Read<string>(reader, ref row.AttackIdle, stringParse); columnno = 19;
			Read<string>(reader, ref row.FishingIdle, stringParse); columnno = 20;
			Read<string>(reader, ref row.Walk, stringParse); columnno = 21;
			Read<string>(reader, ref row.AttackWalk, stringParse); columnno = 22;
			Read<string>(reader, ref row.Run, stringParse); columnno = 23;
			Read<string>(reader, ref row.AttackRun, stringParse); columnno = 24;
			Read<string>(reader, ref row.RunLeft, stringParse); columnno = 25;
			Read<string>(reader, ref row.AttackRunLeft, stringParse); columnno = 26;
			Read<string>(reader, ref row.RunRight, stringParse); columnno = 27;
			Read<string>(reader, ref row.AttackRunRight, stringParse); columnno = 28;
			Read<string>(reader, ref row.MoveFx, stringParse); columnno = 29;
			Read<string>(reader, ref row.Freeze, stringParse); columnno = 30;
			Read<string>(reader, ref row.FreezeFx, stringParse); columnno = 31;
			ReadArray<string>(reader, ref row.Hit_f, stringParse); columnno = 32;
			ReadArray<string>(reader, ref row.Hit_l, stringParse); columnno = 33;
			ReadArray<string>(reader, ref row.Hit_r, stringParse); columnno = 34;
			ReadArray<float>(reader, ref row.HitBackOffsetTimeScale, floatParse); columnno = 35;
			ReadArray<string>(reader, ref row.HitFly, stringParse); columnno = 36;
			ReadArray<float>(reader, ref row.HitFlyOffsetTimeScale, floatParse); columnno = 37;
			ReadArray<string>(reader, ref row.Hit_Roll, stringParse); columnno = 38;
			ReadArray<float>(reader, ref row.HitRollOffsetTimeScale, floatParse); columnno = 39;
			ReadArray<float>(reader, ref row.HitBack_Recover, floatParse); columnno = 40;
			ReadArray<float>(reader, ref row.HitFly_Bounce_GetUp, floatParse); columnno = 41;
			Read<float>(reader, ref row.HitRoll_Recover, floatParse); columnno = 42;
			Read<string>(reader, ref row.HitFx, stringParse); columnno = 43;
			Read<string>(reader, ref row.Death, stringParse); columnno = 44;
			Read<string>(reader, ref row.DeathFx, stringParse); columnno = 45;
			ReadArray<string>(reader, ref row.HitCurves, stringParse); columnno = 46;
			Read<string>(reader, ref row.DeathCurve, stringParse); columnno = 47;
			Read<string>(reader, ref row.A, stringParse); columnno = 48;
			Read<string>(reader, ref row.AA, stringParse); columnno = 49;
			Read<string>(reader, ref row.AAA, stringParse); columnno = 50;
			Read<string>(reader, ref row.AAAA, stringParse); columnno = 51;
			Read<string>(reader, ref row.AAAAA, stringParse); columnno = 52;
			Read<string>(reader, ref row.OtherSkills, stringParse); columnno = 53;
			Read<string>(reader, ref row.SkillNum, stringParse); columnno = 54;
			Read<string>(reader, ref row.Dash, stringParse); columnno = 55;
			Read<string>(reader, ref row.Ultra, stringParse); columnno = 56;
			Read<string>(reader, ref row.Appear, stringParse); columnno = 57;
			Read<string>(reader, ref row.Disappear, stringParse); columnno = 58;
			Read<string>(reader, ref row.FishingCast, stringParse); columnno = 59;
			Read<string>(reader, ref row.FishingPull, stringParse); columnno = 60;
			Read<string>(reader, ref row.FishingWait, stringParse); columnno = 61;
			Read<string>(reader, ref row.FishingWin, stringParse); columnno = 62;
			Read<string>(reader, ref row.FishingLose, stringParse); columnno = 63;
			Read<string>(reader, ref row.Dance, stringParse); columnno = 64;
			Read<string>(reader, ref row.Kiss, stringParse); columnno = 65;
			Read<string>(reader, ref row.InheritActionOne, stringParse); columnno = 66;
			Read<string>(reader, ref row.InheritActionTwo, stringParse); columnno = 67;
			Read<string>(reader, ref row.Atlas, stringParse); columnno = 68;
			Read<string>(reader, ref row.Avatar, stringParse); columnno = 69;
			Read<string>(reader, ref row.Atlas2, stringParse); columnno = 70;
			Read<string>(reader, ref row.Avatar2, stringParse); columnno = 71;
			Read<bool>(reader, ref row.Shadow, boolParse); columnno = 72;
			Read<string>(reader, ref row.Feeble, stringParse); columnno = 73;
			Read<string>(reader, ref row.FeebleFx, stringParse); columnno = 74;
			Read<string>(reader, ref row.ArmorBroken, stringParse); columnno = 75;
			Read<string>(reader, ref row.SuperArmorRecoverySkill, stringParse); columnno = 76;
			Read<string>(reader, ref row.RecoveryFX, stringParse); columnno = 77;
			Read<string>(reader, ref row.RecoveryHitSlowFX, stringParse); columnno = 78;
			Read<string>(reader, ref row.RecoveryHitStopFX, stringParse); columnno = 79;
			row.sortID = (int)row.UID;
			Table[lineno] = row;
			columnno = -1;
        }
    }
}
