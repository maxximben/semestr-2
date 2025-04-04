def prim(n, graph):
    visited = [False] * n
    visited[0] = True
    total_weight = 0
    mst = []
    edges_in_mst = 0

    while edges_in_mst < n - 1:
        min_weight = float('inf')
        min_edge = None
        u = -1


        for i in range(n):
            if visited[i]:
                for v in range(n):
                    if not visited[v] and graph[i][v] > 0:
                        weight = graph[i][v]
                        if weight < min_weight:
                            min_weight = weight
                            min_edge = (i, v)
                            u = v

        if min_edge is None:
            break


        mst.append((min_edge[0], min_edge[1], min_weight))
        total_weight += min_weight
        visited[u] = True
        edges_in_mst += 1

    return mst, total_weight


graph = [
    [0, 1, 3, 0],
    [1, 0, 2, 5],
    [3, 2, 0, 4],
    [0, 5, 4, 0]
]
n = 4
mst, total_weight = prim(n, graph)

print("Минимальное остовное дерево:")
for u, v, weight in mst:
    print(f"{u} - {v}, Вес: {weight}")
print(f"Общий вес: {total_weight}")