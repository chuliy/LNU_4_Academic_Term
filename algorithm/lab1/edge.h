#ifndef EDGE_H
#define EDGE_H

#include <iostream>
class Edge
{
public:
    Edge();
    Edge(int16_t first, int16_t second, double weight);

    int16_t firstVertex() const;
    void setFirstVertex(const int16_t &firstVertex);

    int16_t secondVertex() const;
    void setSecondVertex(const int16_t &secondVertex);

    double weight() const;
    void setWeight(double weight);

private:
    int16_t mFirstVertex;
    int16_t mSecondVertex;
    double mWeight;
};

#endif // EDGE_H
