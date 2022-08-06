'''
1. Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов. 
Это не просто сумма всех коэффициентов.
Сумма многочленов равна многочлену, членами которого являются все члены данных многочленов.
например, в 1 файле было 3*x^3 + 5*x^2+10*x+11, в другом 7*x^2+55
то в итоге будет, 3*x^3 + 12*x^2+10*x+66
'''
from operator import index


def read_file(addres):
    path = addres
    f = open(path, 'r')
    data = f.read() + ' '
    f.close
    return data

mnogochlen1 = read_file('/Users/Admin/Desktop/Homework5/task1.1.txt')
mnogochlen2 = read_file('/Users/Admin/Desktop/Homework5/task1.2.txt')
print(mnogochlen1)
print(mnogochlen2)

def str_to_list(str):
    str = str.replace('= 0', '')
    str = str.replace('*', '')
    str = str.replace('^', '')
    str = str.replace(' ', '')
    str = str.split('+')
    str = list(map(lambda x: x.split('x'), str))
    return str

def slojenie_mnogoclenov(mng1, mng2):
    res = []
    for i in mng1:
        for j in mng2:
            if len(j) == 2 and len(i) == 2:
                if i[1] == j [1]:
                    k = (int(i[0]) + int(j[0]), i[1])
                    res.append(k)
                    break
            elif len(j) == 2 or len(i) == 2:
                    continue
            else:
                k = int(i[0]) + int(j[0])
                res.append(k)
                break
    return res

def new_res_file(list1):
    str = ''
    for i in range(0, len(list1)):
        try:
            list[i] = int(list[i])
            str = str + f'{list[i]}'
        except:
            if list1[i] != 0:
                if i != len(list1)-1 and len(list1)-i != 2:
                    str = str + f'{list1[i][0]}*x^{len(list1)-1-i} + '
                elif len(list1)-i == 2:
                    str = str + f'{list1[i][0]}*x + '
                else:
                    str = str + f'{list1[i]} '
    str = str + '= 0'
    return str

res1 = str_to_list(mnogochlen1)
res2 = str_to_list(mnogochlen2)
print(res1)
print(res2)
result = slojenie_mnogoclenov(res1, res2)
print(result)
result_str = new_res_file(result)
print(result_str)

path = 'result.txt'
file = open('result.txt','w')
file.write(result_str)