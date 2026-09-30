Imports System

Module Program
    Sub Main(args As String())
		' Variable initialization
		Dim max_len As UInteger = 0 ' Maximum length of the sequence where each wave is longer than the previous one
		Dim current_len As UInteger = 0 ' Current length of the sequence where each wave is longer than the previous one
		Dim prev_wave As UInteger = 0 ' Previous value in the input data chain
		Dim b_done As Boolean = False ' Loop control flag
		Console.WriteLine("Enter weather station data (0 to end input).")
		Do While Not b_done ' Start loop
			Dim wave As UInteger = Nothing
			UInteger.TryParse(Console.ReadLine(), wave) ' Input new data
			b_done = (wave = 0) ' Loop termination condition: input is 0
			If current_len = 0 Then
				current_len = 1 ' Initialize length counter to 1
			ElseIf wave > prev_wave Then ' If the current wave is longer than the previous one
				current_len += 1 ' Increment the sequence length counter
			Else
				If current_len > max_len Then ' Otherwise, calculate
					max_len = current_len ' the maximum sequence length
				End If
				current_len = 1 ' and reset the current sequence length counter
			End If
			prev_wave = wave ' Update the previous value with the new one
		Loop
		' Maximum length of the sequence where each wave is longer than the previous one
		' Final result
		If current_len > max_len Then
			max_len = current_len
		End If
		' ---Display output---
		Console.WriteLine($"Maximum sequence length: {max_len}")
		Console.Read() ' Pause output until "Enter" is pressed
	End Sub
End Module
