/*
* <auto-generated>
*	 The code is generated by tools
*	 Edit manually this code will lead to incorrect behavior
* </auto-generated>
*/

#ifndef  __AIRuntimeResetTarget__
#define  __AIRuntimeResetTarget__

#include "../AIBehaviour.h"
#include "../GameObject.h"
#include "../Vector3.h"
#include "../AITreeImpleted.h"

class XEntity;

class AIRuntimeResetTarget :public AIBase
{
public:
	~AIRuntimeResetTarget();
	virtual void Init(AITaskData* data);
	virtual AIStatus OnTick(XEntity* entity);
	

private:
	
};

#endif