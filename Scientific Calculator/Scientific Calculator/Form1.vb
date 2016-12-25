Public Class FormScientificCalculator

    Dim num1 As Double
    Dim num2 As Double
    Dim ans As Double
    Dim op As String
    Dim n As Int64

  


    Private Sub btn_Click(sender As System.Object, e As System.EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click, btnDot.Click, btnZero.Click

        Dim btn As Button = sender
        If lblMainScreen.Text = "0" Then
            lblMainScreen.Text = btn.Text
        Else
            lblMainScreen.Text = lblMainScreen.Text + btn.Text

        End If


    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click

        Dim a As Integer = lblMainScreen.Text Mod 10
        If lblMainScreen.Text.Length = 1 Then
            lblMainScreen.Text = "0"
        Else
            If a > 5 Then

                lblMainScreen.Text = Trim(Convert.ToInt64(lblMainScreen.Text / 10) - 1)
            ElseIf a < 5 Then
                lblMainScreen.Text = Trim(Convert.ToInt64(lblMainScreen.Text / 10))
            ElseIf a = 5 Then
                lblMainScreen.Text = Trim(Convert.ToInt64(lblMainScreen.Text / 10))
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        lblMainScreen.Text = "0"
        lblComplementaryScreen.Text = ""

    End Sub


    Private Sub ArithematicOperations(sender As System.Object, e As System.EventArgs) Handles btnPlus.Click, btnMul.Click, btnMod.Click, btnMinus.Click, btnExp.Click, btnDiv.Click

        Dim local As Button = sender
        num1 = lblMainScreen.Text
        lblComplementaryScreen.Text = lblMainScreen.Text
        lblMainScreen.Text = ""
        op = local.Text
        lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + op


    End Sub

    Private Sub btnEqualTo_Click(sender As System.Object, e As System.EventArgs) Handles btnEqualTo.Click

        num2 = lblMainScreen.Text
        If op = "+" Then
            ans = num1 + num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        ElseIf op = "-" Then
            ans = num1 - num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        ElseIf op = "*" Then
            ans = num1 * num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        ElseIf op = "/" Then
            ans = num1 / num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        ElseIf op = "MOD" Then
            ans = num1 Mod num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        ElseIf op = "EXP" Then
            ans = num1 ^ num2
            lblComplementaryScreen.Text = lblComplementaryScreen.Text + " " + lblMainScreen.Text
            lblMainScreen.Text = ans
        End If


    End Sub

    Private Sub btnReciprocal_Click(sender As System.Object, e As System.EventArgs) Handles btnReciprocal.Click

        ans = 1 / lblMainScreen.Text
        lblComplementaryScreen.Text = "1" + " / " + lblMainScreen.Text
        lblMainScreen.Text = ans


    End Sub

    Private Sub btnSin_Click(sender As System.Object, e As System.EventArgs) Handles btnSin.Click

        ans = Math.Sin(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Sin" + " " + lblMainScreen.Text
        lblMainScreen.Text = ans
        

    End Sub

    Private Sub btnCos_Click(sender As System.Object, e As System.EventArgs) Handles btnCos.Click

        ans = Math.Cos(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Cos" + " " + lblMainScreen.Text
        lblMainScreen.Text = ans


    End Sub

    Private Sub btnTan_Click(sender As System.Object, e As System.EventArgs) Handles btnTan.Click
        ans = Math.Tan(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Tan" + " " + lblMainScreen.Text
        lblMainScreen.Text = ans


    End Sub

    Private Sub btnSqrt_Click(sender As System.Object, e As System.EventArgs) Handles btnSqrt.Click

        ans = Math.Sqrt(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Sqrt(" + " " + lblMainScreen.Text + " )"
        lblMainScreen.Text = ans


    End Sub

    Private Sub btnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnLog.Click

        ans = Math.Log10(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Log(" + " " + lblMainScreen.Text + " )"
        lblMainScreen.Text = ans


    End Sub

    Private Sub btnLn_Click(sender As System.Object, e As System.EventArgs) Handles btnLn.Click

        ans = Math.Log(lblMainScreen.Text)
        lblComplementaryScreen.Text = "Ln(" + " " + lblMainScreen.Text + " )"
        lblMainScreen.Text = ans


    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()


    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click

        MessageBox.Show("This is a Scientific Calculator. In it you can also perform different types of Unit Conversion.")


    End Sub

    Private Sub btnPi_Click(sender As System.Object, e As System.EventArgs) Handles btnPi.Click

        ans = Math.PI
        lblComplementaryScreen.Text = "Pi"
        lblMainScreen.Text = ans


    End Sub

    Private Sub FormScientificCalculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ComboBoxTypeOfConversion.Text = "Choose One.."
        ComboBoxTypeOfConversion.Items.Add("Angle")
        ComboBoxTypeOfConversion.Items.Add("Area")
        ComboBoxTypeOfConversion.Items.Add("Data")
        ComboBoxTypeOfConversion.Items.Add("Energy")
        ComboBoxTypeOfConversion.Items.Add("Length")
        ComboBoxTypeOfConversion.Items.Add("Power")
        ComboBoxTypeOfConversion.Items.Add("Pressure")
        ComboBoxTypeOfConversion.Items.Add("Speed")
        ComboBoxTypeOfConversion.Items.Add("Temperature")
        ComboBoxTypeOfConversion.Items.Add("Time")
        ComboBoxTypeOfConversion.Items.Add("Weight And Mass")
        ComboBoxTypeOfConversion.Items.Add("Volume")


    End Sub

    Private Sub ComboBoxTypeOfConversion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTypeOfConversion.SelectedIndexChanged

        If ComboBoxTypeOfConversion.SelectedItem = "Angle" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Degrees")
            ComboBoxFrom.Items.Add("Gradians")
            ComboBoxFrom.Items.Add("Radians")
            ComboBoxTo.Items.Add("Degrees")
            ComboBoxTo.Items.Add("Gradians")
            ComboBoxTo.Items.Add("Radians")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Area" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Acres")
            ComboBoxFrom.Items.Add("Hectares")
            ComboBoxFrom.Items.Add("Square cm")
            ComboBoxFrom.Items.Add("Square feet")
            ComboBoxFrom.Items.Add("Square inches")
            ComboBoxFrom.Items.Add("Square km")
            ComboBoxFrom.Items.Add("Square m")
            ComboBoxFrom.Items.Add("Square miles")
            ComboBoxFrom.Items.Add("Square mm")
            ComboBoxFrom.Items.Add("Square yards")
            ComboBoxTo.Items.Add("Acres")
            ComboBoxTo.Items.Add("Hectares")
            ComboBoxTo.Items.Add("Square cm")
            ComboBoxTo.Items.Add("Square feet")
            ComboBoxTo.Items.Add("Square inches")
            ComboBoxTo.Items.Add("Square km")
            ComboBoxTo.Items.Add("Square m")
            ComboBoxTo.Items.Add("Square miles")
            ComboBoxTo.Items.Add("Square mm")
            ComboBoxTo.Items.Add("Square yards")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Data" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Bits")
            ComboBoxFrom.Items.Add("Bytes")
            ComboBoxFrom.Items.Add("KiloBytes")
            ComboBoxFrom.Items.Add("MegaBytes")
            ComboBoxFrom.Items.Add("GigaBytes")
            ComboBoxFrom.Items.Add("TeraBytes")
            ComboBoxFrom.Items.Add("PetaBytes")
            ComboBoxFrom.Items.Add("ExaBytes")
            ComboBoxFrom.Items.Add("ZettaBytes")
            ComboBoxFrom.Items.Add("YottaBytes")
            ComboBoxTo.Items.Add("Bits")
            ComboBoxTo.Items.Add("Bytes")
            ComboBoxTo.Items.Add("KiloBytes")
            ComboBoxTo.Items.Add("MegaBytes")
            ComboBoxTo.Items.Add("GigaBytes")
            ComboBoxTo.Items.Add("TeraBytes")
            ComboBoxTo.Items.Add("PetaBytes")
            ComboBoxTo.Items.Add("ExaBytes")
            ComboBoxTo.Items.Add("ZettaBytes")
            ComboBoxTo.Items.Add("YottaBytes")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Energy" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Electron Volts")
            ComboBoxFrom.Items.Add("Joules")
            ComboBoxFrom.Items.Add("KiloJoules")
            ComboBoxFrom.Items.Add("Kilocalories")
            ComboBoxFrom.Items.Add("Food Calories")
            ComboBoxFrom.Items.Add("Foot-Pounds")
            ComboBoxFrom.Items.Add("British Thermal Units")
            ComboBoxTo.Items.Add("Electron Volts")
            ComboBoxTo.Items.Add("Joules")
            ComboBoxTo.Items.Add("KiloJoules")
            ComboBoxTo.Items.Add("Kilocalories")
            ComboBoxTo.Items.Add("Foot Calories")
            ComboBoxTo.Items.Add("Foot-Pounds")
            ComboBoxTo.Items.Add("British Thermal Units")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Length" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Millimeters")
            ComboBoxFrom.Items.Add("Centimeters")
            ComboBoxFrom.Items.Add("Meters")
            ComboBoxFrom.Items.Add("Kilometers")
            ComboBoxFrom.Items.Add("Inches")
            ComboBoxFrom.Items.Add("Feet")
            ComboBoxFrom.Items.Add("Yards")
            ComboBoxFrom.Items.Add("Miles")
            ComboBoxFrom.Items.Add("Nautical Miles")
            ComboBoxTo.Items.Add("Millimeters")
            ComboBoxTo.Items.Add("Centimeters")
            ComboBoxTo.Items.Add("Meters")
            ComboBoxTo.Items.Add("Kilometers")
            ComboBoxTo.Items.Add("Inches")
            ComboBoxTo.Items.Add("Feet")
            ComboBoxTo.Items.Add("Yards")
            ComboBoxTo.Items.Add("Miles")
            ComboBoxTo.Items.Add("Nautical Miles")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Power" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Watt")
            ComboBoxFrom.Items.Add("KiloWatt")
            ComboBoxFrom.Items.Add("HorsePower")
            ComboBoxFrom.Items.Add("Foot-Pound/Minute")
            ComboBoxFrom.Items.Add("BTUs/Minute")
            ComboBoxTo.Items.Add("Watt")
            ComboBoxTo.Items.Add("KiloWatt")
            ComboBoxTo.Items.Add("HorsePower")
            ComboBoxTo.Items.Add("Foot-Pound/Minute")
            ComboBoxTo.Items.Add("BTUs/Minute")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Pressure" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Atmospheres")
            ComboBoxFrom.Items.Add("Bars")
            ComboBoxFrom.Items.Add("Kilopascals")
            ComboBoxFrom.Items.Add("Millimeters Of Mercury")
            ComboBoxFrom.Items.Add("Pascals")
            ComboBoxFrom.Items.Add("Pound Per Sq Inch")
            ComboBoxTo.Items.Add("Atmospheres")
            ComboBoxTo.Items.Add("Bars")
            ComboBoxTo.Items.Add("Kilopascals")
            ComboBoxTo.Items.Add("Millimeters Of Mercury")
            ComboBoxTo.Items.Add("Pascals")
            ComboBoxTo.Items.Add("Pound Per Sq Inch")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Speed" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("m per sec")
            ComboBoxFrom.Items.Add("km per hour")
            ComboBoxFrom.Items.Add("feet per sec")
            ComboBoxFrom.Items.Add("miles per hour")
            ComboBoxFrom.Items.Add("Knots")
            ComboBoxTo.Items.Add("m per sec")
            ComboBoxTo.Items.Add("km per hour")
            ComboBoxTo.Items.Add("feet per sec")
            ComboBoxTo.Items.Add("miles per hour")
            ComboBoxTo.Items.Add("Knots")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Temperature" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Celsius")
            ComboBoxFrom.Items.Add("Fahrenheit")
            ComboBoxFrom.Items.Add("Kelvin")
            ComboBoxTo.Items.Add("Celsius")
            ComboBoxTo.Items.Add("Fahrenheit")
            ComboBoxTo.Items.Add("Kelvin")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Time" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Microseconds")
            ComboBoxFrom.Items.Add("Milliseconds")
            ComboBoxFrom.Items.Add("Seconds")
            ComboBoxFrom.Items.Add("Minutes")
            ComboBoxFrom.Items.Add("Hours")
            ComboBoxFrom.Items.Add("Days")
            ComboBoxFrom.Items.Add("Weeks")
            ComboBoxFrom.Items.Add("Years")
            ComboBoxTo.Items.Add("Microseconds")
            ComboBoxTo.Items.Add("Milliseconds")
            ComboBoxTo.Items.Add("Seconds")
            ComboBoxTo.Items.Add("Minutes")
            ComboBoxTo.Items.Add("Hours")
            ComboBoxTo.Items.Add("Days")
            ComboBoxTo.Items.Add("Weeks")
            ComboBoxTo.Items.Add("Years")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Weight And Mass" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Grams")
            ComboBoxFrom.Items.Add("Milligrams")
            ComboBoxFrom.Items.Add("Micrograms")
            ComboBoxFrom.Items.Add("Metric Tonnes")
            ComboBoxFrom.Items.Add("Kilograms")
            ComboBoxFrom.Items.Add("Ounces")
            ComboBoxFrom.Items.Add("Pounds")
            ComboBoxFrom.Items.Add("Stone")
            ComboBoxFrom.Items.Add("Short Ton")
            ComboBoxTo.Items.Add("Grams")
            ComboBoxTo.Items.Add("Milligrams")
            ComboBoxTo.Items.Add("Micrograms")
            ComboBoxTo.Items.Add("Metric Tonnes")
            ComboBoxTo.Items.Add("Kilograms")
            ComboBoxTo.Items.Add("Ounces")
            ComboBoxTo.Items.Add("Pounds")
            ComboBoxTo.Items.Add("Stone")
            ComboBoxTo.Items.Add("Short Ton")

        ElseIf ComboBoxTypeOfConversion.SelectedItem = "Volume" Then

            ComboBoxTo.Text = ""
            ComboBoxFrom.Text = ""
            ComboBoxTo.DataSource = Nothing
            ComboBoxTo.Items.Clear()
            ComboBoxFrom.DataSource = Nothing
            ComboBoxFrom.Items.Clear()
            ComboBoxFrom.Items.Add("Milliliters")
            ComboBoxFrom.Items.Add("Liters")
            ComboBoxFrom.Items.Add("Cubic Meters")
            ComboBoxFrom.Items.Add("Teaspoons")
            ComboBoxFrom.Items.Add("Tablespoons")
            ComboBoxFrom.Items.Add("Fluid Ounces")
            ComboBoxFrom.Items.Add("Cups")
            ComboBoxFrom.Items.Add("Pints")
            ComboBoxTo.Items.Add("Milliliters")
            ComboBoxTo.Items.Add("Liters")
            ComboBoxTo.Items.Add("Cubic Meters")
            ComboBoxTo.Items.Add("Teaspoons")
            ComboBoxTo.Items.Add("Tablespoons")
            ComboBoxTo.Items.Add("Fluid Ounces")
            ComboBoxTo.Items.Add("Cups")
            ComboBoxTo.Items.Add("Pints")

        End If

    End Sub

    Private Sub ComboBoxFrom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxFrom.SelectedIndexChanged

        lblFrom.Text = ComboBoxFrom.SelectedItem

    End Sub

    Private Sub ComboBoxTo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTo.SelectedIndexChanged

        lblTo.Text = ComboBoxTo.SelectedItem

    End Sub

    Private Sub btnClearUnit_Click(sender As System.Object, e As System.EventArgs) Handles btnClearUnit.Click

        ComboBoxTypeOfConversion.Text = "Choose One.."
        ComboBoxFrom.Text = ""
        ComboBoxTo.Text = ""
        txtbxAccept.Text = ""
        txtbxOut.Text = ""
        lblFrom.Text = ""
        lblTo.Text = ""


    End Sub

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click

        Dim Convrt As Double = Nothing
        If txtbxAccept.Text = "" Then
            txtbxAccept.Text = "0"
        End If
        If ComboBoxFrom.Text = "Degrees" Then

            If ComboBoxTo.Text = "Degrees" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Radians" Then
                Convrt = txtbxAccept.Text * ((Math.PI) / 180)
            ElseIf ComboBoxTo.Text = "Gradians" Then
                Convrt = txtbxAccept.Text * 1.11111111
            End If

        ElseIf ComboBoxFrom.Text = "Radians" Then

            If ComboBoxTo.Text = "Degrees" Then
                Convrt = txtbxAccept.Text * (180 / (Math.PI))
            ElseIf ComboBoxTo.Text = "Radians" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Gradians" Then
                Convrt = txtbxAccept.Text * 63.662
            End If

        ElseIf ComboBoxFrom.Text = "Gradians" Then

            If ComboBoxTo.Text = "Degrees" Then
                Convrt = txtbxAccept.Text * 0.9
            ElseIf ComboBoxTo.Text = "Radians" Then
                Convrt = txtbxAccept.Text * 0.015708
            ElseIf ComboBoxTo.Text = "Gradians" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Acres" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.404686
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 40470000
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 43560
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 6273000.0
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.0040470886795838
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 4047.0886795838
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.0015625896750000022
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 4047000000.0
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 4840.17171738232
            End If

        ElseIf ComboBoxFrom.Text = "Hectares" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 2.47105
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 100000000.0
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 107639
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 15500015.996032
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.01
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 10000
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.00386102
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 10000000000.0
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 11959.9
            End If

        ElseIf ComboBoxFrom.Text = "Square cm" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.0000000247105
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.00000001
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 0.00107639
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 0.155
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.0000000001
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 0.0001
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.00000000003861
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 100
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 0.000119599
            End If

        ElseIf ComboBoxFrom.Text = "Square feet" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.000022957
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.0000092903
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 929.03
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 144
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.000000092903
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 0.092903
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.0000000358700488349403
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 92903
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 0.111111
            End If

        ElseIf ComboBoxFrom.Text = "Square inches" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.00000015942
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.000000064516
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 6.4516
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 0.00694444
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.000000000645159587098
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 0.00064516
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.0000000002491
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 645.16
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 0.000771605
            End If

        ElseIf ComboBoxFrom.Text = "Square km" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 247.105
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 100
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 10000000000.0
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 10760000.0
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 1550000000.0
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.386102
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 1000000000000.0
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 1196000.0
            End If

        ElseIf ComboBoxFrom.Text = "Square m" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.000247105
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.0001
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 10000
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 10.7639
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 1550
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.0000003861
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 1.19599
            End If

        ElseIf ComboBoxFrom.Text = "Square miles" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 640
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 258.999
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 25900000000.0
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 27880000.0
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 4014000000.0
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 2.58999
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 2590000.0
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 2590000000000.0
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 3098000.0
            End If

        ElseIf ComboBoxFrom.Text = "Square mm" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.00000000024711
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.0000000001
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 0.01
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 0.000010764
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 0.00155
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.000000000001
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.0000000000003861
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text * 0.000001196
            End If

        ElseIf ComboBoxFrom.Text = "Square yards" Then

            If ComboBoxTo.Text = "Acres" Then
                Convrt = txtbxAccept.Text * 0.000206612
            ElseIf ComboBoxTo.Text = "Hectares" Then
                Convrt = txtbxAccept.Text * 0.000083613
            ElseIf ComboBoxTo.Text = "Square cm" Then
                Convrt = txtbxAccept.Text * 8361.27
            ElseIf ComboBoxTo.Text = "Square feet" Then
                Convrt = txtbxAccept.Text * 9
            ElseIf ComboBoxTo.Text = "Square inches" Then
                Convrt = txtbxAccept.Text * 1296
            ElseIf ComboBoxTo.Text = "Square km" Then
                Convrt = txtbxAccept.Text * 0.00000083613
            ElseIf ComboBoxTo.Text = "Square m" Then
                Convrt = txtbxAccept.Text * 0.836127
            ElseIf ComboBoxTo.Text = "Square miles" Then
                Convrt = txtbxAccept.Text * 0.00000032283
            ElseIf ComboBoxTo.Text = "Square mm" Then
                Convrt = txtbxAccept.Text * 836127
            ElseIf ComboBoxTo.Text = "Square yards" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Bits" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text / 8
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 1))
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 2))
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 3))
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 4))
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 5))
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 6))
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 7))
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / (8 * Math.Pow(1024, 8))
            End If

        ElseIf ComboBoxFrom.Text = "Bytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 7)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 8)
            End If

        ElseIf ComboBoxFrom.Text = "KiloBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * 1024
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 7)
            End If

        ElseIf ComboBoxFrom.Text = "MegaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * 1024
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 6)
            End If

        ElseIf ComboBoxFrom.Text = "GigaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 5)
            End If

        ElseIf ComboBoxFrom.Text = "TeraBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 4)
            End If

        ElseIf ComboBoxFrom.Text = "PetaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 3)
            End If

        ElseIf ComboBoxFrom.Text = "ExaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 2)
            End If

        ElseIf ComboBoxFrom.Text = "ZettaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 7)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 7)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text / Math.Pow(1024, 1)
            End If

        ElseIf ComboBoxFrom.Text = "YottaBytes" Then

            If ComboBoxTo.Text = "Bits" Then
                Convrt = txtbxAccept.Text * 8 * Math.Pow(1024, 8)
            ElseIf ComboBoxTo.Text = "Bytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 8)
            ElseIf ComboBoxTo.Text = "KiloBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 7)
            ElseIf ComboBoxTo.Text = "MegaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 6)
            ElseIf ComboBoxTo.Text = "GigaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 5)
            ElseIf ComboBoxTo.Text = "TeraBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 4)
            ElseIf ComboBoxTo.Text = "PetaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 3)
            ElseIf ComboBoxTo.Text = "ExaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 2)
            ElseIf ComboBoxTo.Text = "ZettaBytes" Then
                Convrt = txtbxAccept.Text * Math.Pow(1024, 1)
            ElseIf ComboBoxTo.Text = "YottaBytes" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Electron Volts" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 1.6022E-19
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 1.6022E-22
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 3.8293E-23
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 1.5189E-27
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 1.1817E-19
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 1.5186E-22

            End If

        ElseIf ComboBoxFrom.Text = "Joules" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text * 6.242E+18
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 0.000239006
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 0.0000000094804
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 0.737562
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 0.000947817

            End If

        ElseIf ComboBoxFrom.Text = "KiloJoules" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text * 6.242E+21
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 1000
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 0.239006
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 0.0000094804
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 737.562
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 0.947817

            End If

        ElseIf ComboBoxFrom.Text = "Kilocalories" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text * 2.611E+22
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 4184
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 4.184
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 0.000039666
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 3085.96
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 3.96567

            End If

        ElseIf ComboBoxFrom.Text = "Foot Calories" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 6.584E+26
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 105500000.0
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 25210.4
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 77800000.0
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 1.5186E-22

            End If

        ElseIf ComboBoxFrom.Text = "Foot-Pounds" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text * 8.462E+18
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 1.35582
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 0.00135582
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 0.000324048
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 0.000000012854
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text * 0.00128507

            End If

        ElseIf ComboBoxFrom.Text = "British Thermal Units" Then

            If ComboBoxTo.Text = "Electron Volts" Then
                Convrt = txtbxAccept.Text * 6.585E+21
            ElseIf ComboBoxTo.Text = "Joules" Then
                Convrt = txtbxAccept.Text * 1055.06
            ElseIf ComboBoxTo.Text = "KiloJoules" Then
                Convrt = txtbxAccept.Text * 1.05506
            ElseIf ComboBoxTo.Text = "Kilocalories" Then
                Convrt = txtbxAccept.Text * 0.252164
            ElseIf ComboBoxTo.Text = "Foot Calories" Then
                Convrt = txtbxAccept.Text * 0.000010002
            ElseIf ComboBoxTo.Text = "Foot-Pounds" Then
                Convrt = txtbxAccept.Text * 778.169
            ElseIf ComboBoxTo.Text = "British Thermal Units" Then
                Convrt = txtbxAccept.Text

            End If

        ElseIf ComboBoxFrom.Text = "Millimeters" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 0.1
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 0.0393701
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 0.00328084
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 0.00109361
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.00000062137
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.00000053996

            End If

        ElseIf ComboBoxFrom.Text = "Centimeters" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 10
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 0.01
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.00001
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 0.393701
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 0.0328084
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 0.0109361
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.0000062137
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.0000053996

            End If

        ElseIf ComboBoxFrom.Text = "Meters" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 100
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 10
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.0001
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 3.93701
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 3.28084
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 1.09361
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.00062137
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.00053996

            End If

        ElseIf ComboBoxFrom.Text = "Kilometers" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 100000.0
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 1000
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 39370.1
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 3280.84
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 1093.61
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.62137
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.53996

            End If

        ElseIf ComboBoxFrom.Text = "Inches" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 25.4
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 2.54
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 0.0254
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.0000254
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 0.0833333
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 0.0277778
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.000015783
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.000013715

            End If

        ElseIf ComboBoxFrom.Text = "Feet" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 304.8
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 30.48
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 0.3048
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.0003048
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 12
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 0.333333
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.000189394
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.000164579

            End If

        ElseIf ComboBoxFrom.Text = "Yards" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 914.4
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 91.44
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 0.9144
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.0009144
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 36
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 3
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 0.000568182
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.000493737

            End If

        ElseIf ComboBoxFrom.Text = "Miles" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 1.60934
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 160934
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 1609.34
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 63360
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 5280
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 1760
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text * 0.868976

            End If

        ElseIf ComboBoxFrom.Text = "Nautical Miles" Then

            If ComboBoxTo.Text = "Millimeters" Then
                Convrt = txtbxAccept.Text * 1852000
            ElseIf ComboBoxTo.Text = "Centimeters" Then
                Convrt = txtbxAccept.Text * 185200
            ElseIf ComboBoxTo.Text = "Meters" Then
                Convrt = txtbxAccept.Text * 1852
            ElseIf ComboBoxTo.Text = "Kilometers" Then
                Convrt = txtbxAccept.Text * 1.852
            ElseIf ComboBoxTo.Text = "Inches" Then
                Convrt = txtbxAccept.Text * 72913.4
            ElseIf ComboBoxTo.Text = "Feet" Then
                Convrt = txtbxAccept.Text * 6076.12
            ElseIf ComboBoxTo.Text = "Yards" Then
                Convrt = txtbxAccept.Text * 2025.37
            ElseIf ComboBoxTo.Text = "Miles" Then
                Convrt = txtbxAccept.Text * 1.15078
            ElseIf ComboBoxTo.Text = "Nautical Miles" Then
                Convrt = txtbxAccept.Text

            End If

        ElseIf ComboBoxFrom.Text = "Watt" Then

            If ComboBoxTo.Text = "Watt" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "KiloWatt" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "HorsePower" Then
                Convrt = txtbxAccept.Text * 0.00134102
            ElseIf ComboBoxTo.Text = "Foot-Pound/Minute" Then
                Convrt = txtbxAccept.Text * 44.25
            ElseIf ComboBoxTo.Text = "BTUs/Minute" Then
                Convrt = txtbxAccept.Text * 0.056869027
            End If

        ElseIf ComboBoxFrom.Text = "KiloWatt" Then

            If ComboBoxTo.Text = "Watt" Then
                Convrt = txtbxAccept.Text * 1000
            ElseIf ComboBoxTo.Text = "KiloWatt" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "HorsePower" Then
                Convrt = txtbxAccept.Text * 1.34102
            ElseIf ComboBoxTo.Text = "Foot-Pound/Minute" Then
                Convrt = txtbxAccept.Text * 44.25
            ElseIf ComboBoxTo.Text = "BTUs/Minute" Then
                Convrt = txtbxAccept.Text * 0.056869027
            End If

        ElseIf ComboBoxFrom.Text = "HorsePower" Then

            If ComboBoxTo.Text = "Watt" Then
                Convrt = txtbxAccept.Text * 745.7
            ElseIf ComboBoxTo.Text = "KiloWatt" Then
                Convrt = txtbxAccept.Text * 745700.0
            ElseIf ComboBoxTo.Text = "HorsePower" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Foot-Pound/Minute" Then
                Convrt = txtbxAccept.Text * 33000.0
            ElseIf ComboBoxTo.Text = "BTUs/Minute" Then
                Convrt = txtbxAccept.Text * 42.41
            End If

        ElseIf ComboBoxFrom.Text = "Foot-Pound/Minute" Then

            If ComboBoxTo.Text = "Watt" Then
                Convrt = txtbxAccept.Text * 0.023
            ElseIf ComboBoxTo.Text = "KiloWatt" Then
                Convrt = txtbxAccept.Text * 0.000023
            ElseIf ComboBoxTo.Text = "HorsePower" Then
                Convrt = txtbxAccept.Text * 0.00003030303030299
            ElseIf ComboBoxTo.Text = "Foot-Pound/Minute" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "BTUs/Minute" Then
                Convrt = txtbxAccept.Text * 0.00128507
            End If

        ElseIf ComboBoxFrom.Text = "BTUs/Minute" Then

            If ComboBoxTo.Text = "Watt" Then
                Convrt = txtbxAccept.Text * 0.0000175842642
            ElseIf ComboBoxTo.Text = "KiloWatt" Then
                Convrt = txtbxAccept.Text * 0.0175842642
            ElseIf ComboBoxTo.Text = "HorsePower" Then
                Convrt = txtbxAccept.Text * 0.0235808867
            ElseIf ComboBoxTo.Text = "Foot-Pound/Minute" Then
                Convrt = txtbxAccept.Text * 778.169
            ElseIf ComboBoxTo.Text = "BTUs/Minute" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Atmospheres" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text * 1.01325
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text * 101325
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text * 101325000.0
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text * 759.999951996
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text * 14.6959
            End If

        ElseIf ComboBoxFrom.Text = "Bars" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text * 0.986923
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text * 100000
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text * 100000000.0
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text * 750.062
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text * 14.5038
            End If

        ElseIf ComboBoxFrom.Text = "Pascals" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text * 0.0000098692
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text * 0.00001
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text * 0.00750062
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text * 0.000145038
            End If

        ElseIf ComboBoxFrom.Text = "Kilopascals" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text * 0.0000000098692
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text * 0.00000001
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text * 0.00000750062
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text * 0.000000145038
            End If

        ElseIf ComboBoxFrom.Text = "Millimeters Of Mercury" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text * 0.00131579
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text * 0.00133322
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text * 133.322
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text * 133322.0
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text * 0.0193368
            End If

        ElseIf ComboBoxFrom.Text = "Pound Per Sq Inch" Then

            If ComboBoxTo.Text = "Atmospheres" Then
                Convrt = txtbxAccept.Text * 0.068046
            ElseIf ComboBoxTo.Text = "Bars" Then
                Convrt = txtbxAccept.Text * 0.0689476
            ElseIf ComboBoxTo.Text = "Pascals" Then
                Convrt = txtbxAccept.Text * 6894.76
            ElseIf ComboBoxTo.Text = "Kilopascals" Then
                Convrt = txtbxAccept.Text * 6894760.0
            ElseIf ComboBoxTo.Text = "Millimeters Of Mercury" Then
                Convrt = txtbxAccept.Text * 51.7149
            ElseIf ComboBoxTo.Text = "Pound Per Sq Inch" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "m per sec" Then

            If ComboBoxTo.Text = "m per sec" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "km per hour" Then
                Convrt = txtbxAccept.Text * 3.6
            ElseIf ComboBoxTo.Text = "feet per sec" Then
                Convrt = txtbxAccept.Text * 3.28084
            ElseIf ComboBoxTo.Text = "miles per hour" Then
                Convrt = txtbxAccept.Text * 2.23694
            ElseIf ComboBoxTo.Text = "Knots" Then
                Convrt = txtbxAccept.Text * 1.94384

            End If

        ElseIf ComboBoxFrom.Text = "km per hour" Then

            If ComboBoxTo.Text = "m per sec" Then
                Convrt = txtbxAccept.Text * 0.277778
            ElseIf ComboBoxTo.Text = "km per hour" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "feet per sec" Then
                Convrt = txtbxAccept.Text * 0.911344
            ElseIf ComboBoxTo.Text = "miles per hour" Then
                Convrt = txtbxAccept.Text * 0.621371
            ElseIf ComboBoxTo.Text = "Knots" Then
                Convrt = txtbxAccept.Text * 0.539957

            End If

        ElseIf ComboBoxFrom.Text = "feet per sec" Then

            If ComboBoxTo.Text = "m per sec" Then
                Convrt = txtbxAccept.Text * 0.3048
            ElseIf ComboBoxTo.Text = "km per hour" Then
                Convrt = txtbxAccept.Text * 1.09728
            ElseIf ComboBoxTo.Text = "feet per sec" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "miles per hour" Then
                Convrt = txtbxAccept.Text * 0.681818
            ElseIf ComboBoxTo.Text = "Knots" Then
                Convrt = txtbxAccept.Text * 0.592484

            End If

        ElseIf ComboBoxFrom.Text = "miles per hour" Then

            If ComboBoxTo.Text = "m per sec" Then
                Convrt = txtbxAccept.Text * 0.44704
            ElseIf ComboBoxTo.Text = "km per hour" Then
                Convrt = txtbxAccept.Text * 1.60934
            ElseIf ComboBoxTo.Text = "feet per sec" Then
                Convrt = txtbxAccept.Text * 1.46667
            ElseIf ComboBoxTo.Text = "miles per hour" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Knots" Then
                Convrt = txtbxAccept.Text * 0.868976

            End If

        ElseIf ComboBoxFrom.Text = "Knots" Then

            If ComboBoxTo.Text = "m per sec" Then
                Convrt = txtbxAccept.Text * 0.514444
            ElseIf ComboBoxTo.Text = "km per hour" Then
                Convrt = txtbxAccept.Text * 1.852
            ElseIf ComboBoxTo.Text = "feet per sec" Then
                Convrt = txtbxAccept.Text * 1.68781
            ElseIf ComboBoxTo.Text = "miles per hour" Then
                Convrt = txtbxAccept.Text * 1.15078
            ElseIf ComboBoxTo.Text = "Knots" Then
                Convrt = txtbxAccept.Text

            End If

        ElseIf ComboBoxFrom.Text = "Celsius" Then

            If ComboBoxTo.Text = "Celsius" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Fahrenheit" Then
                Convrt = txtbxAccept.Text * 1.8 + 32
            ElseIf ComboBoxTo.Text = "Kelvin" Then
                Convrt = txtbxAccept.Text + 273.15
            End If

        ElseIf ComboBoxFrom.Text = "Fahrenheit" Then

            If ComboBoxTo.Text = "Celsius" Then
                Convrt = (txtbxAccept.Text - 32) / 1.8
            ElseIf ComboBoxTo.Text = "Fahrenheit" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Kelvin" Then
                Convrt = (txtbxAccept.Text + 459.67) / 1.8
            End If

        ElseIf ComboBoxFrom.Text = "Kelvin" Then

            If ComboBoxTo.Text = "Celsius" Then
                Convrt = txtbxAccept.Text - 273.15
            ElseIf ComboBoxTo.Text = "Fahrenheit" Then
                Convrt = txtbxAccept.Text * 1.8 - 459.67
            ElseIf ComboBoxTo.Text = "Kelvin" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Microseconds" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 0.000000016667
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 0.00000000027778
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 0.000000000011574
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.0000000000016534
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.00000000000003171
            End If

        ElseIf ComboBoxFrom.Text = "Milliseconds" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 1000
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 0.000016667
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 0.00000027778
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 0.000000011574
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.0000000016534
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.00000000003171
            End If

        ElseIf ComboBoxFrom.Text = "Seconds" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 0.016667
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 0.00027778
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 0.000011574
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.0000016534
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.00000003171
            End If

        ElseIf ComboBoxFrom.Text = "Minutes" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 60000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 60000
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 60
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 0.0166667
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 0.000694444
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.000099206
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.0000019026
            End If

        ElseIf ComboBoxFrom.Text = "Hours" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 3600000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 3600000.0
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 3600.0
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 60
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 0.0416667
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.00595238
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.000114155
            End If

        ElseIf ComboBoxFrom.Text = "Days" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 86400000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 86400000.0
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 86400
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 1440
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 24
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 0.142857
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.00273973
            End If

        ElseIf ComboBoxFrom.Text = "Weeks" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 604800000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 604800000.0
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 604800
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 10080
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 168
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 7
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text * 0.0191781
            End If

        ElseIf ComboBoxFrom.Text = "Years" Then

            If ComboBoxTo.Text = "Microseconds" Then
                Convrt = txtbxAccept.Text * 31540000000000.0
            ElseIf ComboBoxTo.Text = "Milliseconds" Then
                Convrt = txtbxAccept.Text * 31540000000.0
            ElseIf ComboBoxTo.Text = "Seconds" Then
                Convrt = txtbxAccept.Text * 31540000.0
            ElseIf ComboBoxTo.Text = "Minutes" Then
                Convrt = txtbxAccept.Text * 525600
            ElseIf ComboBoxTo.Text = "Hours" Then
                Convrt = txtbxAccept.Text * 8760
            ElseIf ComboBoxTo.Text = "Days" Then
                Convrt = txtbxAccept.Text * 365
            ElseIf ComboBoxTo.Text = "Weeks" Then
                Convrt = txtbxAccept.Text * 52.1429
            ElseIf ComboBoxTo.Text = "Years" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Grams" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 1000
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 0.035274
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 0.00220462
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.000157473
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.0000011023
            End If

        ElseIf ComboBoxFrom.Text = "Milligrams" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.000000001
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 0.000035274
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 0.00000220462
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.000000157473
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.0000000011023
            End If

        ElseIf ComboBoxFrom.Text = "Micrograms" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.000000000001
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 0.000000001
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 0.000000035274
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 0.00000000220462
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.000000000157473
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.0000000000011023
            End If

        ElseIf ComboBoxFrom.Text = "Metric Tonnes" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 1000000000.0
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 1000000000000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 35274.0
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 2204.62
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 157.473
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 1.1023
            End If

        ElseIf ComboBoxFrom.Text = "Kilograms" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 1000000000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 35.274
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 2.20462
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.157473
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.0011023
            End If

        ElseIf ComboBoxFrom.Text = "Ounces" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 28.3495
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 28349.5
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 28349500.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.0000283495
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 0.0283495
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 0.0625
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.00446429
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.00003125
            End If

        ElseIf ComboBoxFrom.Text = "Pounds" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 453.592
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 453592.0
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 453592000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.000453592
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 0.453592
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 16
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 0.0714286
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.0005
            End If

        ElseIf ComboBoxFrom.Text = "Stone" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 6350.29
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 6350290.0
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 6350290000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.00635029
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 6.35029
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 224
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 14
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text * 0.007
            End If

        ElseIf ComboBoxFrom.Text = "Short Ton" Then

            If ComboBoxTo.Text = "Grams" Then
                Convrt = txtbxAccept.Text * 907185
            ElseIf ComboBoxTo.Text = "Milligrams" Then
                Convrt = txtbxAccept.Text * 907185000.0
            ElseIf ComboBoxTo.Text = "Micrograms" Then
                Convrt = txtbxAccept.Text * 907185000000.0
            ElseIf ComboBoxTo.Text = "Metric Tonnes" Then
                Convrt = txtbxAccept.Text * 0.907185
            ElseIf ComboBoxTo.Text = "Kilograms" Then
                Convrt = txtbxAccept.Text * 907.185
            ElseIf ComboBoxTo.Text = "Ounces" Then
                Convrt = txtbxAccept.Text * 32000
            ElseIf ComboBoxTo.Text = "Pounds" Then
                Convrt = txtbxAccept.Text * 2000
            ElseIf ComboBoxTo.Text = "Stone" Then
                Convrt = txtbxAccept.Text * 142.857
            ElseIf ComboBoxTo.Text = "Short Ton" Then
                Convrt = txtbxAccept.Text
            End If

        ElseIf ComboBoxFrom.Text = "Milliliters" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.000001
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 0.168936
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 0.0563121
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 0.033814
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 0.00351951
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 0.00175975
            End If

        ElseIf ComboBoxFrom.Text = "Liters" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.001
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 168.936
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 56.3121
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 33.814
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 3.51951
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 1.75975
            End If

        ElseIf ComboBoxFrom.Text = "Cubic Meters" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 1000000.0
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 1000.0
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 168936.0
            ElseIf ComboBoxTo.Text = "TableSpoons" Then
                Convrt = txtbxAccept.Text * 56312.1
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 33814.0
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 3519.51
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 1759.75
            End If

        ElseIf ComboBoxFrom.Text = "Teaspoons" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 5.91939
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.00591939
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.0000059194
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 0.333333
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 0.200158
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 0.0208333
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 0.0104167
            End If

        ElseIf ComboBoxFrom.Text = "Tablespoons" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 17.7582
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.0177582
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.0000177582
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 3
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 0.600475
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 0.0625
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 0.03125
            End If

        ElseIf ComboBoxFrom.Text = "Fluid Ounces" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 29.5735
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.0295735
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.0000295735
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 4.99604
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 1.66535
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 0.104084
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 0.0520421
            End If

        ElseIf ComboBoxFrom.Text = "Cups" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 284.131
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.284131
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.000284131
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 48
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 16
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 9.6076
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text * 0.5
            End If

        ElseIf ComboBoxFrom.Text = "Pints" Then

            If ComboBoxTo.Text = "Milliliters" Then
                Convrt = txtbxAccept.Text * 568.261
            ElseIf ComboBoxTo.Text = "Liters" Then
                Convrt = txtbxAccept.Text * 0.568261
            ElseIf ComboBoxTo.Text = "Cubic Meters" Then
                Convrt = txtbxAccept.Text * 0.000568261
            ElseIf ComboBoxTo.Text = "Teaspoons" Then
                Convrt = txtbxAccept.Text * 96
            ElseIf ComboBoxTo.Text = "Tablespoons" Then
                Convrt = txtbxAccept.Text * 32
            ElseIf ComboBoxTo.Text = "Fluid Ounces" Then
                Convrt = txtbxAccept.Text * 19.2152
            ElseIf ComboBoxTo.Text = "Cups" Then
                Convrt = txtbxAccept.Text * 2
            ElseIf ComboBoxTo.Text = "Pints" Then
                Convrt = txtbxAccept.Text
            End If


        End If


        txtbxOut.Text = Convrt


    End Sub

End Class

