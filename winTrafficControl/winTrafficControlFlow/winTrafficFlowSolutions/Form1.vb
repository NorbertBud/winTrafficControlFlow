Imports System.IO
Public Class mainScene

    Dim SimulatedTrafficData As String = "C:\Users\PC\Desktop\Software Development\winTrafficControl\winTrafficControlFlow\winTrafficFlowSolutions\TrafficData.txt" 'this adds the variable into the prgramme(This is where the program gets its data from, please change it based on your directory of the "TrafficData.txt" file).

    Private Sub btnTotalTrafficflow_Click(sender As Object, e As EventArgs) Handles btnTotalTrafficflow.Click


        File.Exists(SimulatedTrafficData) 'this line fo code makes sure that the text file exists
        Dim streamR As StreamReader 'this allows the computer to read the file
        streamR = File.OpenText(SimulatedTrafficData) 'this declares sr will read the data file
        Dim record As String 'this declares 'record' as a string
        Dim totalVehicleFlow As Integer 'this declares 'totalVehicleFlow' as an integer

        Do While streamR.Peek() <> -1

            record = streamR.ReadLine 'this will read a line from the data file
            totalVehicleFlow += 1 'this will add 1 to the total traffic flow after each line is read
        Loop

        txtTotalTrafficflow.Text = CStr(totalVehicleFlow) 'this line of code is made so the user can see the output in text.

    End Sub

    Private Sub btnPercentageOfVehicleType_Click(sender As Object, e As EventArgs) Handles btnPercentageOfVehicleType.Click

        Dim currRecord As String 'to store a current record in the variable "currRecord"
        Dim currWeight As Integer 'this is an integer that will hold the weight of each vehicle
        Dim recordArray() As String 'this is to record each array
        Dim motorBikeCount As Integer 'this counts how many motorbikes are there based on weight
        Dim carCount As Integer 'this counts how many cars are there based on weight
        Dim vanCount As Integer 'this counts how many vans are there based on weight
        Dim lorryCount As Integer 'this counts how many lorries are there based on weight

        'This will assign "StreamReader" to "sr" so we can use it more efficiently as you dont have to type the whole syntax of the function.
        Dim sr As StreamReader

        'this step checks if the file actually exists and if it does then all the calculations can be made
        Try
            If File.Exists(SimulatedTrafficData) Then
                sr = File.OpenText(SimulatedTrafficData) 'this line of code reads whats inside the file

                Do While sr.Peek() <> -1 'if the file to read is not empty
                    currRecord = sr.ReadLine
                    recordArray = currRecord.Split(","c) 'this line of code assigns every line to arrays, index 0, index 1 etc.

                    currWeight = recordArray(3).ToString 'store the current weight in the ages array at current index

                    If currWeight > 1 And currWeight < 699 Then 'this declares the weight values for a bike
                        motorBikeCount += 1 'this is a counter that collects the data
                    ElseIf currWeight > 700 And currWeight < 4600 Then 'this declares the weight values for a car
                        carCount += 1 'this is a counter that collects the data
                    ElseIf currWeight > 4601 And currWeight < 7899 Then 'this declares the weight values for a van
                        vanCount += 1 'this is a counter that collects the data
                    ElseIf currWeight > 7900 And currWeight < 20000 Then 'this declares the weight values for a lorry
                        lorryCount += 1 'this is a counter that collects the data

                    End If

                Loop
                sr.Close()
                'display the calculations after the loop
                lblVehicleCounts.Text = "Motor Bikes: " & motorBikeCount 'this will display the result of number of bikes and give a name for the result.
                lblVehicleCounts.Text &= Chr(13) 'this will spereate the results. (put them on seperate line)
                lblVehicleCounts.Text &= "Cars: " & carCount 'this will display the result of number of cars and give a name for the result.
                lblVehicleCounts.Text &= Chr(13) 'this will spereate the results. (put them on seperate line)
                lblVehicleCounts.Text &= "Vans: " & vanCount 'this will display the result of number of vans and give a name for the result.
                lblVehicleCounts.Text &= Chr(13) 'this will spereate the results. (put them on seperate line)
                lblVehicleCounts.Text &= "Lorry: " & lorryCount 'this will display the result of number of lorrys and give a name for the result.
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click 'when user clicks the button this function is executed
        Try 'this is just a shortuct as we assign the file location into a variable "fileLocation"
            Dim fileLocation As String = "C:\Users\PC\Desktop\Software Development\winTrafficControl\winTrafficControlFlow\winTrafficFlowSolutions\Report.txt"

            If File.Exists("C:\Users\PC\Desktop\Software Development\winTrafficControl\winTrafficControlFlow\winTrafficFlowSolutions\Report.txt") Then 'this checks if the file is in that location
                Dim sWriter As StreamWriter 'another shortcut so we dont have to repeat "StreamWriter" all the time.
                sWriter = File.AppendText(fileLocation) 'this line of code creates a StreamWriter tat appends UTF-8 encoded text to an existing file.
                sWriter.WriteLine("Report1: Traffic Vehicle Counts:" & Chr(13) & System.DateTime.Now) 'this writes a line to the text file that says "Report1: Traffic Vehicle Counts: ***" and outputs date
                sWriter.WriteLine(lblVehicleCounts.Text & ", Total vehicle flow on that day: " & txtTotalTrafficflow.Text) 'This line of code will output all the vehicles as well as traffic flow for a specific text file into a report.
                sWriter.Close() 'closes the StreamReader"
                MsgBox("Result written to file sucessfully!") 'this will be displayed if everything was performed correctly.
            Else
                MsgBox("Something went wrong!") 'if the program was't able to find the file it will display an error.
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("The program will now close") ' this function closes users program on their demand and outputs a text message.
        Me.Close()

    End Sub

    Private Sub btnPercentageOfVehicleType_ContextMenuChanged(sender As Object, e As EventArgs) Handles btnPercentageOfVehicleType.ContextMenuChanged

    End Sub
End Class