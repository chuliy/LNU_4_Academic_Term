#ifndef LOGIC_H
#define LOGIC_H

#include "subset.h"
#include "edge.h"
#include "graph.h"

#include <vector>
#include <algorithm>
#include <iostream>

class Logic
{
public:
    static size_t find(std::vector<Subset> &subsets,const size_t i);

    static void Union(std::vector<Subset> &subsets, size_t x, size_t y);
    static void Kruskal(Graph* graph);

    Logic()=delete;
};

#endif // LOGIC_H
