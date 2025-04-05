def wawe_aglorithm(field, start, finish):
    field.insert(0, [-1]*len(field[0]))
    field.insert(len(field), [-1]*len(field[0]))

    for i in range(len(field)):
        field[i].insert(0, -1)
        field[i].insert(len(field[i]), -1)


    for i in range(2):
        start[i] += 1
        finish[i] += 1


    directions = [(0, 1), (0, -1), (1, 0), (-1, 0)]


    wave = [start]
    field[start[0]][start[1]] = 0


    found = False
    while wave and not found:
        new_wave = []
        for x, y in wave:
            for dx, dy in directions:
                nx, ny = x + dx, y + dy
            
                if (nx < 0 or ny < 0 or nx >= len(field) or ny >= len(field[0]) or
                    field[nx][ny] == -1 or field[nx][ny] == "x" or 
                    field[nx][ny] != 0):
                    continue
                
            
                field[nx][ny] = field[x][y] + 1
                new_wave.append([nx, ny])
            
           
                if [nx, ny] == finish:
                    found = True
                    break
                
        wave = new_wave

    if found:
        print("длина пути: ", field[finish[0]][finish[1]])
        print()
        for i in range(1, len(field) - 1):
            for j in range(1, len(field) - 1):
                print(field[i][j], " ", end="")
            print("\n")
    else:
        print("путь не найден")


field = [
    [0, 0, 0, "x", "x"],
    [0, "x", 0, 0, 0],
    [0, 0, 0, "x", 0],
    [0, 0, 0, "x", 0],
    [0, 0, 0, "x", 0]
]

start = [3, 1]
finish = [3, 4]

wawe_aglorithm(field, start, finish)
