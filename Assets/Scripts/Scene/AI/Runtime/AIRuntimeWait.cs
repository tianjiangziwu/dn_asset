// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AI.Runtime {
    using UnityEngine;
    
    
    public class AIRuntimeWait : AIRunTimeBase {
        
        public float floatwaitTime;
        
        public bool boolrandomWait;
        
        public float floatrandomWaitMin;
        
        public float floatrandomWaitMax;
        
        public override void Init(AI.Runtime.AIRuntimeTaskData data) {
			base.Init(data);
			if(data.vars[0].val != null)
				floatwaitTime = (System.Single)data.vars[0].val;
			if(data.vars[1].val != null)
				boolrandomWait = (System.Boolean)data.vars[1].val;
			if(data.vars[2].val != null)
				floatrandomWaitMin = (System.Single)data.vars[2].val;
			if(data.vars[3].val != null)
				floatrandomWaitMax = (System.Single)data.vars[3].val;
        }
        
        public override AIRuntimeStatus OnTick(XEntity entity) {
			return AITreeImpleted.WaitUpdate(entity, floatwaitTime, boolrandomWait, floatrandomWaitMin, floatrandomWaitMax);
        }
    }
}
