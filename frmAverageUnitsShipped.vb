'Name: Connor Simmonds-Parke
'Student ID: 100344939
'Course: NETD - 2202
'Project: Lab3AverageUnitsShipped
'Date: Mar 6, 2018
'Description: A program to calculate the average amount of units shipped over a week, for three
'             employees, using user inputted data and storing it in an array. Once all the
'             entries are inputted, this program will then calculate and display the total average
'             units shipped for the week.

Option Strict On

Public Class frmAverageUnitsShipped

    'DECLARATIONS

    'GLOBAL VARIABLES
    Dim unitsShippedArray(2, 6) As Integer 'Two dimensional array to hold the user's input for units shipped on each day by the employee.
    Dim dayCounter As Integer = 0 'Variable to count the days.
    Dim employeeCounter As Integer = 0 'Variable to count the employees.
    Dim totalUnitsShippedAverage As Double = 0.0 'Variable to hold the sum and then average of the average of all employee's units shipped.

    ''' <summary>
    ''' Checks to see if the user input is a whole number and then if it is range. Displays a message box
    ''' error output if the input is invalid.
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <param name="validUserInput"></param>
    ''' <returns></returns>
    Private Function isValid(ByVal userInput As String, ByRef validUserInput As Integer) As Boolean

        'DECLARATIONS

        'CONSTANTS
        Const minimumUnits As Integer = 0 'Constant to hold the minumum units sold per day.
        Const maximumUnits As Integer = 1000 'Constant to hold the maximum units sold per day.

        'VARIABLES
        Dim userWholeNumber As Integer = 0 'Variable to hold the result of the try parse check to see if user input is a whole number.
        Dim returnValue As Boolean = True 'Variable to hold the return value for the calling code.
        Dim output As String = String.Empty 'Variable to hold the error output, if any.

        'INPUT

        If (Integer.TryParse(userInput, userWholeNumber)) Then 'Checks to see if the input is a whole number.

            If (userWholeNumber >= minimumUnits AndAlso userWholeNumber <= maximumUnits) Then 'Checks to see if the input is within range.

                'PROCESSING

                'If it passes all the checks, returns these values to/for the calling code.
                validUserInput = userWholeNumber
                returnValue = True

            Else 'If the input didn't pass the range check.

                returnValue = False 'Sets the return value for the calling code.
                output = "The units shipped can only be between 0 and 1000." 'Sets the output for the message box.

            End If

        Else 'If the input didn't pass the whole number check.

            returnValue = False 'Sets the return value for the calling code.
            output = "Please enter a whole number for units shipped." 'Sets the output for the message box.

        End If

        'OUTPUT

        If (returnValue = False) Then 'Checks to see if the return value for the calling code is false (didn't pass the checks).

            MessageBox.Show(output) 'Displays a messagebox that holds the output error to the user.

        End If

        Return returnValue

    End Function

    ''' <summary>
    ''' Loops through the form to reset every control and variable to the original state.
    ''' </summary>
    Private Sub resetForm()

        For Each currentControl As Object In Me.Controls 'Loops through each of the controls within the group box variable.

            If (TypeOf (currentControl) Is TextBox) Then 'Checks to see if the control in the loop is a text box.

                CType(currentControl, TextBox).Clear() 'Clears the textbox.

                If (CType(currentControl, TextBox).ReadOnly = True) Then 'Checks to see if the textbox is in read only.

                    CType(currentControl, TextBox).ReadOnly = False 'Turns read only off (units input textbox).

                End If

            ElseIf (TypeOf (currentControl) Is Label) Then 'Checks to see if the control is a label.

                If (CType(currentControl, Label).BorderStyle = BorderStyle.Fixed3D) Then 'Checks to see if the label is an output label (all outputs on this form use Fixed3D borders).

                    CType(currentControl, Label).Text = String.Empty 'Clears the label.

                End If

            ElseIf (TypeOf (currentControl) Is Button) Then 'Checks to see if the control is a button.

                If (CType(currentControl, Button).Enabled = False) Then 'Checks to see if the button is disabled.

                    CType(currentControl, Button).Enabled = True 'Enables the button (enter button).

                End If

            End If

        Next currentControl

        txtUnitsInput.Focus() 'Sets the focus back to the units textbox.

        'Resets all the variables.
        employeeCounter = 0
        dayCounter = 0
        totalUnitsShippedAverage = 0.0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close() 'Closes this form, thus closing the program.

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        resetForm() 'Calls to the function that resets the form.

    End Sub

    ''' <summary>
    ''' Stores the user's input if it passes the validation check into the two dimensional array. Also increments the day
    ''' and employee counter if the input was valid. Once seven days worth of data have been inputed (all inputs for an 
    ''' employee), calculates and displays the average for that employee and moves to the next employee. Once all employee's 
    ''' data have been entered, calculates and displays the total average units shipped for all employees and locks the 
    ''' program so no more data can be entered until the user resets the program.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'DECLARATIONS

        'CONSTANTS
        Const numberOfDays As Integer = 7 'Constant to hold the number of days that the program is taking user input for.
        Const numberOfEmployees As Integer = 3 'Constant to hold the number of employees the program can average for.

        'VARIABLES
        Dim userInput As String = String.Empty 'Variable to hold the user's input from the textbox for units shipped.
        Dim validUserInput As Integer = 0 'Variable to hold the try parse value for the user's input.
        Dim textBoxList() As TextBox = {txtEmployeeOneUnitsList, txtEmployeeTwoUnitsList, txtEmployeeThreeUnitsList} 'Array to hold the output textboxes that list the user's input.
        Dim labelList() As Label = {lblEmployeeOneAverage, lblEmployeeTwoAverage, lblEmployeeThreeAverage} 'Array to hold the output labels that display the average for each employee.
        Dim unitsShippedAverage As Double = 0.0 'Variable to hold the average units shipped for each employee.

        'INPUT

        userInput = txtUnitsInput.Text 'Gets the user's input from the textbox for units shipped.

        If (isValid(userInput, validUserInput)) Then 'Calls to the validation function to check if the input is valid.

            'PROCESSING
            unitsShippedArray(employeeCounter, dayCounter) = validUserInput 'Sets the value of the index in the global array to the user's input.
            textBoxList(employeeCounter).Text += validUserInput & vbCrLf.ToString 'Displays the user's input in the output textbox.
            dayCounter += 1 'Increase the day counter by one.

            'OUTPUT
            txtUnitsInput.Clear() 'Clears the input textbox.
            txtUnitsInput.Focus() 'Sets the focus to the input textbox.
            lblDaysDisplay.Text = "Day " & (dayCounter + 1) 'Increments the day label by one.

        Else 'If the input failed the validation check from the validation function.

            'OUTPUT
            txtUnitsInput.Focus() 'Sets the focus to the input textbox.
            txtUnitsInput.SelectAll() 'Selects all the text in the input box for user ease of use.

        End If

        'PROCESSING

        If (dayCounter = numberOfDays) Then 'Checks to see if input has been made for the whole week.

            For averageCounter = 0 To (numberOfDays - 1) 'Loop to get the sum of the array of units shipped for the employee.

                unitsShippedAverage += unitsShippedArray(employeeCounter, averageCounter) 'Sums up the units shipped.

            Next

            unitsShippedAverage = (unitsShippedAverage / numberOfDays) 'Calculates the average units shipped for the emplooyee.
            totalUnitsShippedAverage += unitsShippedAverage 'Adds the average to the global variable that will be used to calculate the total average.
            employeeCounter += 1 'Increments the employee counter by one.
            dayCounter = 0 'Resets the day counter to 0 (for the next employee).

            'OUTPUT

            labelList(employeeCounter - 1).Text = "Average: " & unitsShippedAverage.ToString("n2") 'Displays the average for the employee to two decimal places.
            lblDaysDisplay.Text = "Day 1" 'Resets the day label (for the next employee).

        End If

        'PROCESSING

        If employeeCounter = numberOfEmployees Then 'Checks to see if all the employees' units shipped have been entered.

            totalUnitsShippedAverage = (totalUnitsShippedAverage / numberOfEmployees) 'Calculates the total average units shipped from all employees.

            'OUTPUT

            btnEnter.Enabled = False 'Locks the enter button so user can't enter anymore data.
            txtUnitsInput.ReadOnly = True 'Turns off the textbox so user can't enter anymore data.
            lblTotalAverage.Text = "Average per day: " & totalUnitsShippedAverage.ToString("n2") 'Displays the total average to two decimal places.

        End If

    End Sub

End Class
