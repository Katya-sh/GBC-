# GBC-
# Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
# Описание:
Задача решена с помощью метода в который передается два массива:
Исходный и пустой для отсортированных элементов.
В методе с помощью цикла  проверяется каждый элемент исходного массива на условие  (<= 3  символам) и если условие выполняется элемент заносится в массив созданный для отсортированных элементов. В роли индекса для отсортированного масива выступает переменная count.

* Блок-схема метода находится в папке bs.
* Реализация задачи в папке Console.