mip20230215
# Итоговая проверочная работа
## Разбиваем на блоки
* Узнаем количество строк, оргиниального массива, спрашиваем у пользователя
* Ввод эллементов массива
* Создание нового массива, размером равному основному
* Выбор в него элементов удовлетворяющих условия, подсчет количества элементов.
* Создание итогового массива, размера равному количеству элементов.
* Вывести оригинальный массива и итоговый

## Разбиваем на методы
* int **ReadKeyboardInt**(string prompt)
* string **ReadKeyboardString**(string prompt)
* string[] **MakeAnArray**(int length), используем :
    * ReadKeyboardInt 
    * ReadKeyboardString 
* int **SearchNeedfulElements**(string[] arrayOrigin, string arrayNew);
* bool **WhatWeNeed**(string element)
* string[] **CropArray**(string[] arrayIn, int length)
* void **PrintArray**(string prompt, string[] array)
* void **PrintString**(string prompt, string text)
