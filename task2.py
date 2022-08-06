'''''
2. Дан список чисел. Создайте список, в который попадают числа, описываемые возрастающую последовательность. Порядок элементов менять нельзя.

Пример:

[1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
[1, 5, 2, 3, 4, 1, 7] => [1, 5]
'''
list_a = [1, 5, 3, 4, 6, 1, 7]

def min_max(list):
    minimal = min(list)
    maximum = minimal+1
    res = []
    for i in range(len(list)): 
        if maximum in list:
            maximum +=1
        else:
            maximum -=1
            break
    if minimal == maximum:
        list.remove(minimal)
        min_max(list)
    else:
        res.append(minimal)
        res.append(maximum)
        print(res)

min_max(list_a)