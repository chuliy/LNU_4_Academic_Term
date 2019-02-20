#ifndef SUBSET_H
#define SUBSET_H

#include <iostream>
class Subset
{
public:
    Subset();
    Subset(int16_t parent, int16_t rank);
    int16_t parent() const;
    void setParent(const int16_t &parent);

    int16_t rank() const;
    void setRank(const int16_t &rank);

private:
    int16_t mParent;
    int16_t mRank;
};

#endif // SUBSET_H
