import numpy as np

inf = float("inf")

graph = [
    [inf, 19, 2, 28, 32],
    [12, inf, 5, 40, 20],
    [22, 10, inf, 50, 10],
    [28, 27, 17, inf, 7],
    [36, 28, 10, 60, inf]
]

sum = 0
for n in range(len(graph) - 1):
    length = len(graph)

    for i in range(length):
        min_i = min(graph[i])
        sum += min_i
        for j in range(length):
            graph[i][j] -= min_i

    min_j_list = [inf] * length
    for i in range(length):
        for j in range(length):
            if graph[j][i] < min_j_list[i]: 
                min_j_list[i] = graph[j][i]
        sum += min_j_list[i]

    for i in range(length):
        for j in range(length):
            graph[j][i] -= min_j_list[i]



    min_i_list = [inf] * length
    for i in range(length):
        if graph[i].count(0) > 1:
            min_i_list[i] = 0
        else:
            min_i_list[i] = min(filter(lambda x: x != 0, graph[i]))


    min_j_list = [inf] * length
    for i in range(length):
        zero_count = 0
        for j in range(length):
            if graph[j][i] == 0:
                zero_count += 1
            elif graph[j][i] < min_j_list[i]:
                min_j_list[i] = graph[j][i]
            if zero_count > 1:
                min_j_list[i] = 0
                break

    max_val = 0
    max_i, max_j = 0, 0
    for i in range(length):
        for j in range(length):
            if graph[i][j] == 0:
                zero_coef = min_i_list[i] + min_j_list[j]
                if zero_coef > max_val:
                    max_val = zero_coef
                    max_i, max_j = i, j

    graph[max_j][max_i] = inf

    graph = [
        [val for j, val in enumerate(row) if j != max_j]
        for i, row in enumerate(graph) if i != max_i
    ]

print(sum)
