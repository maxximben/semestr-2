def find(parent, u):
    if parent[u] != u:
        parent[u] = find(parent, parent[u])
    return parent[u]

def union(parent, rank, u, v):
    root_u = find(parent, u)
    root_v = find(parent, v)

    if root_u != root_v:
        if rank[root_u] > rank[root_v]:
            parent[root_v] = root_u
        elif rank[root_u] < rank[root_v]:
            parent[root_u] = root_v
        else:
            parent[root_v] = root_u
            rank[root_u] += 1

def kruskal(n, graph):
    edges = []

    for i in range(n):
        for j in range(i + 1, n):
            weight = graph[i][j]
            if weight > 0:
                edges.append((weight, i, j))


    edges.sort()

    parent = list(range(n))
    rank = [0] * n
    mst = []
    total_weight = 0

    for weight, u, v in edges:
        if find(parent, u) != find(parent, v):
            union(parent, rank, u, v)
            mst.append((u, v, weight))
            total_weight += weight

    return mst, total_weight


graph = [
    [0, 1, 3, 0],
    [1, 0, 2, 5],
    [3, 2, 0, 4],
    [0, 5, 4, 0]
]
n = 4
mst, total_weight = kruskal(n, graph)

print("Минимальное остовное дерево:")
for u, v, weight in mst:
    print(f"{u} - {v}, Вес: {weight}")
print(f"Общий вес: {total_weight}")