#ifndef EDGE_H
#define EDGE_H

#include <iostream>
class Edge
{
public:
    Edge();
    Edge(size_t first, size_t second, size_t weight);

    size_t firstVertex() const;
    void setFirstVertex(const size_t &firstVertex);

    size_t secondVertex() const;
    void setSecondVertex(const size_t &secondVertex);

    size_t weight() const;
    void setWeight(size_t weight);

    void setAll(size_t first, size_t second, size_t weight);

private:
    size_t mFirstVertex;
    size_t mSecondVertex;
    size_t mWeight;
};

#endif // EDGE_H
