# Итоговая контрольная работа по основному блоку

## Постановление задачи

**Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма

1. На старте программы имеем два массива: `startArray`, который содержит в себе данные для проверки корректности работы програмы, и массив `endArray`, который будет содержать в себе результат работы программы.

2. Функция `SearchResult` последовательно перебирает элементы массива `startArray` и, при условии что i-й элемент массива имеет длину меньшую, либо равную 3 добавляет этот элемент в массив `endArray`.

3. Функция `PrintResult` перебирает элементы массива `endArray`, получившегося в результате работы функции `SearchResult`, и выводит их на экран.