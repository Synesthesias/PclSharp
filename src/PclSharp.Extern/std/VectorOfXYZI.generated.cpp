// Code generated by a template
#pragma once
#include "..\export.h"
#include <vector>
#include "pcl\point_types.h"


using namespace std;
using namespace pcl;


typedef vector<PointXYZI> vectorType;

#ifdef __cplusplus  
extern "C" {  
#endif

EXPORT(vectorType*) std_vector_xyzi_ctor()
{
	return new vector<PointXYZI>();
}

EXPORT(vectorType*) std_vector_xyzi_ctor_count(int count)
{
	return new vector<PointXYZI>(count);
}

EXPORT(void) std_vector_xyzi_delete(vector<PointXYZI>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(void) std_vector_xyzi_at(vector<PointXYZI>* ptr, size_t idx, PointXYZI* value)
{
	*value = ptr->at(idx);
}

EXPORT(size_t) std_vector_xyzi_size(vector<PointXYZI>* ptr)
{
	return ptr->size();
}

EXPORT(void) std_vector_xyzi_clear(vector<PointXYZI>* ptr)
{
	ptr->clear();
}

EXPORT(void) std_vector_xyzi_resize(vector<PointXYZI>* ptr, int32_t size)
{
	ptr->resize(size);
}

EXPORT(void) std_vector_xyzi_add(vector<PointXYZI>* ptr, PointXYZI value)
{
	//the value needs to be aligned to be pushed into the cloud, so do that.
	PointXYZI deref;
	memcpy(&deref, &value, sizeof(PointXYZI));
	ptr->push_back(deref);
}

EXPORT(void) std_vector_xyzi_insert(vector<PointXYZI>* ptr, ptrdiff_t index, PointXYZI value)
{
	//the value needs to be aligned to be pushed into the cloud, so do that.
	PointXYZI deref;
	memcpy(&deref, &value, sizeof(PointXYZI));
	ptr->insert(ptr->begin()+index, deref);
}

EXPORT(PointXYZI*) std_vector_xyzi_data(vector<PointXYZI>* ptr)
{
	return ptr->data();
}

#ifdef __cplusplus  
}
#endif