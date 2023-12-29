/*
Challenge from the Microsoft training for C# Foundations to create an automatic gradebook that
calculates student assignments, grades, and extra credit assignments and assigns weight and
calculates a final grade, including a letter grade, extra credit grade, and total extra credit points
achieved.
*/

using System;

int examAssignments = 5;

double[] sophiaScores = new double[] {90, 86, 87, 98, 100, 94, 90};
double[] andrewScores = new double[] {92, 89, 81, 96, 90, 89};
double[] emmaScores = new double[] {90, 85, 87, 98, 68, 89, 89, 89};
double[] loganScores = new double[] {90, 95, 87, 88, 96, 96};
double[] studentScores = new double[10];
string currentStudentLetterGrade = "";
string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else
        continue;

    double sumAssignmentScores = 0;
    double sumExamScores = 0;
    double currentStudentGrade = 0;
    double currentStudentExamGrade = 0;
    int gradedAssignments = 0;
    int extraCreditAssignments = studentScores.Length - examAssignments;
    double extraCreditGrades = 0;
    double sumExtraCreditGrades = 0;

    foreach (double score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            sumExamScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
        
        if (gradedAssignments > examAssignments)
        {
            sumExtraCreditGrades += (score*.1) / examAssignments;
            extraCreditGrades += score / extraCreditAssignments;
        }
    }

    currentStudentGrade = sumAssignmentScores / examAssignments;
    currentStudentExamGrade = sumExamScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamGrade}\t\t{currentStudentGrade.ToString("0.00")}\t{currentStudentLetterGrade}\t{extraCreditGrades} ({(decimal)sumExtraCreditGrades} pts)");
    
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
