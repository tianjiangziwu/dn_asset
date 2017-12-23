/*
 * <auto-generated>
 *	 The code is generated by tools
 *	 Edit manually this code will lead to incorrect behavior
 * </auto-generated>
 */

#ifndef __[*Table*]__
#define __[*Table*]__

#include "NativeReader.h"
#include "Log.h"
#include <vector>
[\\]#include <unordered_map>


struct [*Table*]Row
{
	[**var**]
};

class [*Table*]:public NativeReader
{
public:
	[*Table*](void);
	void ReadTable();
	void GetRow(int val,[*Table*]Row* row);
	[\\]void GetByUID(uint id, [*Table*]Row* row);
	int GetLength();

protected:
	std::string name;
	std::vector<[*Table*]Row> m_data;
	[\\]std::unordered_map<uint, [*Table*]Row> m_map;
};


extern "C"
{
	ENGINE_INTERFACE_EXPORT int iGet[*Table*]Length();
	ENGINE_INTERFACE_EXPORT void iGet[*Table*]Row(int idx,[*Table*]Row* row);
	[\\]ENGINE_INTERFACE_EXPORT void iGet[*Table*]RowByID(uint id, [*Table*]Row* row);
};

#endif