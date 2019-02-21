#include "edge.h"

Edge::Edge()
    :mFirstVertex(0), mSecondVertex(0), mWeight(0.0)
{   }

size_t Edge::firstVertex() const
{
    return mFirstVertex;
}

void Edge::setFirstVertex(const size_t &firstVertex)
{
    mFirstVertex = firstVertex;
}

size_t Edge::secondVertex() const
{
    return mSecondVertex;
}

void Edge::setSecondVertex(const size_t &secondVertex)
{
    mSecondVertex = secondVertex;
}

size_t Edge::weight() const
{
    return mWeight;
}

void Edge::setWeight(size_t weight)
{
    mWeight = weight;
}

void Edge::setAll(size_t first, size_t second, size_t weight)
{
    mFirstVertex = first;
    mSecondVertex = second;
    mWeight = weight;
}
