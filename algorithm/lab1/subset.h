#ifndef SUBSET_H
#define SUBSET_H

#include <iostream>
class Subset
{
public:
    Subset();
    Subset(size_t parent, size_t rank);
    size_t parent() const;
    void setParent(const size_t &parent);

    size_t rank() const;
    void setRank(const size_t &rank);

private:
    size_t mParent;
    size_t mRank;
};

#endif // SUBSET_H
