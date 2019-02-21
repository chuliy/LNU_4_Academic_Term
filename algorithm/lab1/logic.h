#ifndef LOGIC_H
#define LOGIC_H

#include "subset.h"
#include "edge.h"
#include "graph.h"

#include <vector>
#include <algorithm>
#include <iostream>
int myComp(const void *a, const void *b);

class Logic
{
public:
    size_t find(std::vector<Subset> &subsets,const size_t i);

    void Union(std::vector<Subset> &subsets, size_t x, size_t y);
    void Kruskal(Graph* graph);


    Logic()=delete;
};

#endif // LOGIC_H
