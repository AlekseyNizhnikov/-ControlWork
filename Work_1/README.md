# Задача

## Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 (трем) символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение:

1. Даем пользователю ввести пять любых строк. С помощью команды Console.ReadLine(), считываем введеные пользователем значения и записываем полученные стркои в строковый массив array. Попутно, с помощью условия if (array[i] == ""), не даем пользователю ввести пустую строку.

2. Полученный массив, передаем в метод FilterLongString.

3. Внутри метода FilterLongString, проходимся по циклу, от начала до конца массива array. При этом проверяем длину каждого из его значений. 
    * Если значение array[i].Length >= 3, то записываем данное значение в новый массив new_array
    * Иначе смещяем индекс масива new_array на один назад, что бы не оставлять посреди массива, пустых значений.
    * Затем переходим к следующему элементу массива array[i]

4. После завершения цикла, внутри метода FilterLongString, вызываем метод PrintArray, для красивого вывода нового массива на экран.

5. Внутри метода PrintArray, также запускаем цикл, чтобы пройтись по всем значениям массива new_array и последовательно выводим на экран его содержимое.
