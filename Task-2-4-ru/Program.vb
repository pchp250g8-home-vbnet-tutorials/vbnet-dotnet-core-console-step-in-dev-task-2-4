Imports System

Module Program
    Sub Main(args As String())
		' Ининциализация переменных
		Dim max_len As UInteger = 0 ' Максимальная длина участка, где каждая волна длинее предыдущей
		Dim current_len As UInteger = 0 ' Текущая длина участка, где каждая волна длинее предыдущей
		Dim prev_wave As UInteger = 0 ' Предыдущее значение в цепочке вводимых данных
		Dim b_done As Boolean = False ' Флаг контроля выполнения цикла
		Console.WriteLine("Введите данные метеостанции (0 - конец ввода).")
		Do While Not b_done ' Старт цикла
			Dim wave As UInteger = Nothing
			UInteger.TryParse(Console.ReadLine(), wave) ' Ввод новой порции данных
			b_done = (wave = 0) ' Условие окончания цикла - ввод 0
			If current_len = 0 Then
				current_len = 1 ' Счётчик длины установили в 1
			ElseIf wave > prev_wave Then ' если каждая волна длинее предыдущей
				current_len += 1 ' то счётчик длины участка увеличить на 1
			Else
				If current_len > max_len Then ' В противном случае вычислить
					max_len = current_len ' максимальную длину участка
				End If
				current_len = 1 ' и сбросить счётчик текущей длины участка
			End If
			prev_wave = wave ' Предыдущее значение заменить новым
		Loop
		' Максимальная длина участка, где каждая волна длинее предыдущей
		' Окончательный ответ
		If current_len > max_len Then
			max_len = current_len
		End If
		' ---Вывод информации на экран---
		Console.WriteLine($"Максимальная длина участка: {max_len}")
		Console.Read() ' Задержка вывода на экран до нажатия клавиши "Ввод"
	End Sub
End Module