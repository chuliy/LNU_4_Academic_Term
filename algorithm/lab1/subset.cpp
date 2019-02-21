#include "subset.h"

Subset::Subset()
    : mParent(0), mRank(0)
{

}

Subset::Subset(size_t parent, size_t rank)
    :mParent(parent),mRank(rank)
{

}

size_t Subset::parent() const
{
    return mParent;
}

void Subset::setParent(const size_t &parent)
{
    mParent = parent;
}

size_t Subset::rank() const
{
    return mRank;
}

void Subset::setRank(const size_t &rank)
{
    mRank = rank;
}
