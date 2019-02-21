#include "edge.h"

Edge::Edge()
    :mFirstVertex(0), mSecondVertex(0), mWeight(0.0)
{   }

int16_t Edge::firstVertex() const
{
    return mFirstVertex;
}

void Edge::setFirstVertex(const int16_t &firstVertex)
{
    mFirstVertex = firstVertex;
}

int16_t Edge::secondVertex() const
{
    return mSecondVertex;
}

void Edge::setSecondVertex(const int16_t &secondVertex)
{
    mSecondVertex = secondVertex;
}

double Edge::weight() const
{
    return mWeight;
}

void Edge::setWeight(double weight)
{
    mWeight = weight;
}

void Edge::setAll(int16_t first, int16_t second, double weight)
{
    mFirstVertex = first;
    mSecondVertex = second;
    mWeight = weight;
}
