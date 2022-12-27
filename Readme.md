Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм решения:
Задается массив строк.
Далее создается метод CountThreeDigitElements, который возвращает колличество строк в заданном массиве (k), длина которых меньше либо равна 3 символа. Эта задача реализуется следующим образом:
-обьявляется переменная-счетчик (k), равная нулю,
-с помощью цикла for (колличество итераций от нуля до длины заданного массива) проверяется условие (меньше либо равно 3 символа),
-если условие выполняется, то счетчик (k) увеличивается на единицу.
Далее объявляется массив строк, где указывется дина (k) - результат выполнения предыдущего метода CountThreeDigitElements.
Создается метод CreateNewArray, который заполняет новый массив строк с помощью цикла for (колличество итераций от нуля до длины заданного массива). Проверяется условие (меньше либо равно 3 символа) и, если условие выполняется, то элементу нового массива присваивается значение из изначально заданного.
Метод PrintArray выводит массивы на экран. 

Графическое представление основной содержательной части: FinalTask-C-/MethodsScheme.jpeg.

Реализация алгоритма: FinalTask-C-/Program.cs