#include "subset.h"

Subset::Subset()
    : mParent(0), mRank(0)
{

}

Subset::Subset(int16_t parent, int16_t rank)
    :mParent(parent),mRank(rank)
{

}

int16_t Subset::parent() const
{
    return mParent;
}

void Subset::setParent(const int16_t &parent)
{
    mParent = parent;
}

int16_t Subset::rank() const
{
    return mRank;
}

void Subset::setRank(const int16_t &rank)
{
    mRank = rank;
}
