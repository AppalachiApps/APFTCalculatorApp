using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;
using System;
using System.Collections;



namespace App8
{
    [Activity(Label = "APFT Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity 
    {
        int[] RangeOneMP = new int[] {0,0,0,0,0,9,10,12,13,14,16,17,19,20,21,23,24,26,27,28,30,31,32,34,35,37,38,39,41,42,43,45,46,48,49,50,52,53,54,56,57,59,60,61,63,64,66,67,68,70,71,72,74,75,77,78,79,81,82,83,85,86,88,89,90,92,93,94,96,97,99,100};
        int[] RangeTwoMP = new int[] {0,0,0,0,0,20,21,22,23,25,26,27,28,29,30,31,33,34,35,36,37,38,39,41,42,43,44,45,46,47,49,50,51,52,53,54,55,57,58,59,60,61,62,63,65,66,67,68,69,70,71,73,74,75,76,77,78,79,81,82,83,84,85,86,87,89,90,91,92,93,94,95,97,98,99,100};
        int[] RangeThreeMP = new int[] {0,0,0,0,0,24,25,26,27,28,29,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,91,92,93,94,95,96,97,98,99,100 };
        int[] RangeFourMP = new int[] {0,0,0,0,0,28,29,30,31,32,33,34,35,36,37,38,39,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100 };
        int[] RangeFiveMP = new int[] {0,0,0,0,0,30,31,32,33,34,35,36,37,38,39,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100 };
        int[] RangeSixMP = new int[] {0,0,0,0,0,32,33,34,36,37,38,39,40,41,42,43,44,46,47,48,49,50,51,52,53,54,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,86,87,88,89,90,91,92,93,94,96,97,98,99,100 };
        int[] RangeSevenMP = new int[] {0,0,0,0,0,36,38,39,40,41,42,45,46,47,48,49,50,51,52,53,54,55,56,58,59,60,61,62,64,65,66,67,68,69,71,72,73,74,75,76,78,79,80,81,82,85,86,87,88,89,90,91,92,93,94,95,96,98,99,100 };
        int[] RangeEightMP = new int[] {0,0,0,0,0,43,44,46,47,48,49,50,51,52,53,54,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,86,87,88,89,90,91,92,94,95,96,97,98,99,100 };
        int[] RangeOneFP = new int[] {0,0,0,0,0,36,37,39,41,43,44,46,48,50,51,53,55,57,58,60,62,63,65,67,69,70,72,74,76,77,79,81,83,84,86,88,90,91,93,95,97,98,100};
        int[] RangeTwoFP = new int[] {0,0,0,0,0,43,45,45,48,49,49,50,52,54,56,57,59,60,61,63,64,66,67,68,70,71,72,74,75,77,78,79,81,82,83,85,86,88,89,90,92,93,94,96,97,99,100};
        int[] RangeThreeFP = new int[] {0,0,0,0,0,45,47,48,49,49,50,52,54,55,56,58,59,60,61,62,64,65,66,67,68,70,71,72,73,75,76,77,78,79,81,82,83,84,85,87,88,89,90,92,93,94,95,96,98,99,100};
        int[] RangeFourFP = new int[] {0,0,0,0,0,47,48,49,49,50,52,54,58,58,59,60,61,63,64,65,67,68,69,71,72,73,75,76,77,79,80,81,83,84,85,87,88,89,91,92,93,95,96,97,99,100};
        int[] RangeFiveFP = new int[] {0,0,0,0,0,48,50,51,53,54,56,57,59,60,61,63,64,66,67,69,70,72,73,75,76,78,79,81,82,84,85,87,88,90,91,93,94,96,97,99,100};
        int[] RangeSixFP = new int[] {0,0,0,0,0,49,50,52,54,55,57,58,60,62,63,65,66,68,70,71,73,74,76,78,79,81,82,84,86,87,89,90,92,94,95,97,98,100};
        int[] RangeSevenFP = new int[] {0,0,0,0,0,52,53,55,57,58,60,62,63,65,67,68,70,72,73,75,77,78,80,82,83,85,87,88,90,92,93,95,97,98,100};
        int[] RangeEightFP = new int[] {0,0,0,0,0,53,55,56,58,60,62,64,65,67,69,71,73,75,76,78,80,82,84,85,87,89,91,93,95,96,99,100};
        int[] RangeOneS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9,10,12,14,15,17,18,20,22,23,25,26,28,30,31,33,34,36,38,39,41,42,44,45,47,49,50,52,54,55,57,58,60,62,63,65,66,68,70,71,73,74,76,78,79,81,82,84,87,88,89,90,92,94,95,97,98,100};
        int[] RangeTwoS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,21,23,24,25,27,28,29,31,32,33,35,36,37,39,40,41,43,44,45,47,48,49,50,52,53,55,56,57,59,60,61,63,64,65,67,68,69,71,72,73,75,76,77,79,80,81,83,84,85,87,88,89,91,92,93,95,96,97,99,100};
        int[] RangeThreeS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,34,35,36,37,38,39,41,42,43,44,45,46,47,48,49,50,51,52,54,55,56,57,58,59,60,61,62,63,64,65,66,68,69,70,71,72,73,74,75,76,77,78,79,81,82,83,84,85,86,87,88,89,90,91,92,94,95,96,97,98,99,100};
        int[] RangeFourS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,36,38,39,40,41,42,44,45,46,47,48,49,50,52,53,54,55,56,58,59,60,61,62,64,65,66,67,68,69,71,72,73,74,75,76,78,79,80,81,82,84,85,86,87,88,89,91,92,93,94,95,96,98,99,100};
        int[] RangeFiveS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,42,43,44,45,46,47,48,49,50,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,91,92,93,94,95,96,97,98,99,100};
        int[] RangeSixS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
        int[] RangeSevenS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,51,52,53,54,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,86,87,88,89,90,91,92,93,94,96,97,98,99,100};
        int[] RangeEightS = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,91,92,93,94,95,96,97,98,99,100};
        string soldierStats;
        string soldier;
        string[] savedResults = new string[100];
        int pushups;
        int situps;
        string run;
        DateTime runTime;
        //string soldier;
        string gender;
        string ageGroup;
        int score;
        int p;
        int s;
        int runScoreMin;
        int runScoreSec;
        int r;
        double age3;
        double neck;
        string gender3;
        double waist;
        double height;
        double maleFat;
        double femFat;
        double hip;

        //set up a formula for age group standards
        private void calculateScore(string gender, string ageGroup)
        {
            this.gender = gender;
            this.ageGroup = ageGroup;
            if (gender == "Male")
            {
                if (ageGroup == "17-21")
                {
                    if (pushups > RangeOneMP.Length)
                    {
                        p = 100;
                        s = RangeOneS[situps];
                    }
                    else if (situps > RangeOneS.Length)
                    {
                        s = 100;
                        p = RangeOneMP[pushups];
                    }
                    else if (pushups > RangeOneMP.Length && situps>RangeOneS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeOneMP[pushups];
                        s = RangeOneS[situps];
                    }
                }
                else if (ageGroup == "22-26")
                {
                    if (pushups > RangeTwoMP.Length)
                    {
                        p = 100;
                        s = RangeTwoS[situps];
                    }
                    else if (situps > RangeTwoS.Length)
                    {
                        s = 100;
                        p = RangeTwoMP[pushups];
                    }
                    else if (pushups > RangeTwoMP.Length && situps > RangeTwoS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeTwoMP[pushups];
                        s = RangeTwoS[situps];
                    }
                }
                else if (ageGroup == "27-31")
                {
                    if (pushups > RangeThreeMP.Length)
                    {
                        p = 100;
                        s = RangeThreeS[situps];
                    }
                    else if (situps > RangeThreeS.Length)
                    {
                        p = RangeThreeMP[pushups];
                        s = 100;
                    }
                    else if (pushups > RangeThreeMP.Length && situps > RangeThreeS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeThreeMP[pushups];
                        s = RangeThreeS[situps];
                    }
                }
                else if (ageGroup == "32-36")
                {
                    if (pushups > RangeFourMP.Length)
                    {
                        p = 100;
                        s = RangeFourS[situps];
                    }
                    else if (situps > RangeFourS.Length)
                    {
                        s = 100;
                        p = RangeFourMP[pushups];
                    }
                    else if (pushups > RangeFourMP.Length && situps > RangeFourS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeFourMP[pushups];
                        s = RangeFourS[situps];
                    }
                }
                else if (ageGroup == "37-41")
                {
                    if (pushups > RangeFiveMP.Length)
                    {
                        p = 100;
                        s = RangeFiveS[situps];
                    }
                    else if (situps > RangeFiveS.Length)
                    {
                        s = 100;
                        p = RangeFiveMP[pushups];
                    }
                    else if (pushups > RangeFiveMP.Length && situps > RangeFiveS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeFiveMP[pushups];
                        s = RangeFiveS[situps];
                    }
                }
                else if (ageGroup == "42-46")
                {
                    if (pushups > RangeSixMP.Length)
                    {
                        p = 100;
                        s = RangeSixS[situps];
                    }
                    else if (situps > RangeSixS.Length)
                    {
                        s = 100;
                        p = RangeSixMP[pushups];
                    }
                    else if (pushups > RangeSixMP.Length && situps > RangeSixS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeSixMP[pushups];
                        s = RangeSixS[situps];
                    }
                }
                else if (ageGroup == "47-51")
                {
                    if (pushups > RangeSevenMP.Length)
                    {
                        p = 100;
                        s = RangeSevenS[situps];
                    }
                    else if (situps > RangeSevenS.Length)
                    {
                        p = RangeSevenMP[pushups];
                        s = 100;
                    }
                    else if (pushups > RangeSevenMP.Length && situps > RangeSevenS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeSevenMP[pushups];
                        s = RangeSevenS[situps];
                    }
                }
                else if (ageGroup == "52+")
                {
                    if (pushups > RangeEightMP.Length)
                    {
                        p = 100;
                        s = RangeEightS[situps];
                    }
                    else if (situps > RangeEightS.Length)
                    {
                        s = 100;
                        p = RangeEightMP[pushups];
                    }
                    else if (pushups > RangeEightMP.Length && situps > RangeEightS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeEightMP[pushups];
                        s = RangeEightS[situps];
                    }
                }
            }
            else if(gender == "Female")
            {
                if (ageGroup == "17-21")
                {
                    if (pushups > RangeOneFP.Length)
                    {
                        p = 100;
                        s = RangeOneS[situps];
                    }
                    else if (situps > RangeOneS.Length)
                    {
                        s = 100;
                        p = RangeOneFP[pushups];
                    }
                    else if (pushups > RangeOneFP.Length && situps > RangeOneS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeOneFP[pushups];
                        s = RangeOneS[situps];
                    }
                }
                else if (ageGroup == "22-26")
                {
                    if (pushups > RangeTwoFP.Length)
                    {
                        p = 100;
                        s = RangeTwoS[situps];
                    }
                    else if (situps > RangeTwoS.Length)
                    {
                        s = 100;
                        p = RangeTwoFP[pushups];
                    }
                    else if (pushups > RangeTwoFP.Length && situps > RangeTwoS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeTwoFP[pushups];
                        s = RangeTwoS[situps];
                    }
                }
                else if (ageGroup == "27-31")
                {
                    if (pushups > RangeThreeFP.Length)
                    {
                        p = 100;
                        s = RangeThreeS[situps];
                    }
                    else if (situps > RangeThreeS.Length)
                    {
                        s = 100;
                        p = RangeThreeFP[pushups];
                    }
                    else if (pushups > RangeThreeFP.Length && situps > RangeThreeS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeThreeFP[pushups];
                        s = RangeThreeS[situps];
                    }
                }
                else if (ageGroup == "32-36")
                {
                    if (pushups > RangeFourFP.Length)
                    {
                        p = 100;
                        s = RangeFourS[situps];
                    }
                    else if (situps > RangeFourS.Length)
                    {
                        s = 100;
                        p = RangeFourFP[pushups];
                    }
                    else if (pushups > RangeFourFP.Length && situps > RangeFourS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeFourFP[pushups];
                        s = RangeFourS[situps];
                    }
                }
                else if (ageGroup == "37-41")
                {
                    if (pushups > RangeFiveFP.Length)
                    {
                        p = 100;
                        s = RangeFiveS[situps];
                    }
                    else if (situps > RangeFiveS.Length)
                    {
                        s = 100;
                        p = RangeFiveFP[pushups];
                    }
                    else if (pushups > RangeFiveFP.Length && situps > RangeFiveS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeFiveFP[pushups];
                        s = RangeFiveS[situps];
                    }
                }
                else if (ageGroup == "42-46")
                {
                    if (pushups > RangeSixFP.Length)
                    {
                        p = 100;
                        s = RangeSixS[situps];
                    }
                    else if (situps > RangeSixS.Length)
                    {
                        s = 100;
                        p = RangeSixFP[pushups];
                    }
                    else if (pushups > RangeSixFP.Length && situps > RangeSixS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeSixFP[pushups];
                        s = RangeSixS[situps];
                    }
                }
                else if (ageGroup == "47-51")
                {
                    if (pushups > RangeSevenFP.Length)
                    {
                        p = 100;
                        s = RangeSevenS[situps];
                    }
                    else if (situps > RangeSevenS.Length)
                    {
                        s = 100;
                        p = RangeSevenFP[pushups];
                    }
                    else if (pushups > RangeSevenFP.Length && situps > RangeSevenS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeSevenFP[pushups];
                        s = RangeSevenS[situps];
                    }
                }
                else if (ageGroup == "52+")
                {
                    if (pushups > RangeEightFP.Length)
                    {
                        p = 100;
                        s = RangeEightS[situps];
                    }
                    else if (situps > RangeEightS.Length)
                    {
                        s = 100;
                        p = RangeEightFP[pushups];
                    }
                    else if (pushups > RangeEightFP.Length && situps > RangeEightS.Length)
                    {
                        p = 100;
                        s = 100;
                    }
                    else
                    {
                        p = RangeEightFP[pushups];
                        s = RangeEightS[situps];
                    }
                }
            }
            if(p+s+r != 0)
            {
                score = p + s + r;
            }
            else
            {

            }

            
        }
        //calculate run score
        private void convertTime(string date, string gender, string ageGroup)
        {
            runTime = DateTime.Parse(date);
            {
                if(runTime.Hour.ToString() == "")
                {
                    
                }
                else if(runTime.Minute.ToString() == "")
                {
                     
                }
                
                else if(runTime.Hour.ToString() != "" && runTime.Minute.ToString() != "")
                {
                    runScoreMin = runTime.Hour;
                    runScoreSec = runTime.Minute;
                    if(gender == "Male")
                    {
                        if (ageGroup == "17-21")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 12)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 1;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 2;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 3;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 5;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 6;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 8;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 9;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 10;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 12;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 13;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 14;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 17;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 18;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 19;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 20;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 21;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 23;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 24;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 26;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 27;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 28;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 30;
                            }
                            else if (runScoreMin == 17 && runScoreSec<=59 && runScoreSec>54)
                            {
                                r = 31;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec >48)
                            {
                                r = 32;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 34;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 35;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 37;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 38;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 39;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 99;
                            }
                            else if(runScoreMin <=12)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "22-26")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <=42 && runScoreSec>36)
                            {
                                r = 14;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 16;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 17;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 18;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 19;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 20;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 21;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 22;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 23;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 24;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 26;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 27;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 28;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 29;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 30;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 31;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 32;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 33;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 34;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 36;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 37;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 38;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 39;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 40;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 99;
                            }
                            else if (runScoreMin <= 12)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "27-31")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 19;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 20;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 21;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 22;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 23;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 24;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 25;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 28;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 29;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 30;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 31;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 32;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 33;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 34;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 35;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 36;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 37;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 38;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 39;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 18)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 12)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "32-36")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 33;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 34;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 35;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 35;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 36;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 37;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 38;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 39;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 40;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 18)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 12)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "37-41")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 40;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 40;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 13 && runScoreSec <= 36)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <=12)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "42-46")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 46;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 13)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "47-51")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 100;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 18 && runScoreSec >= 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 13)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "52-56")
                        {
                            if (runScoreMin > 20)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 59 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 & runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 100;
                            }
                            else if (runScoreMin == 14 && runScoreSec <= 36 && runScoreSec >=0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 13)
                            {
                                r = 100;
                            }
                        }
                        else
                        {

                        }
                    }
                    else if(gender == "Female")
                    {
                        if(ageGroup == "17-21")
                        {
                            if(runScoreMin >=21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if(runScoreMin == 20 && runScoreSec<=42 && runScoreSec>36)
                            {
                                r = 38;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 39;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 41;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 42;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 43;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 44;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >=0)
                            {
                                r = 45;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 47;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 48;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec >=0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 14)
                            {
                                r = 100;
                            }
                            
                        }
                        else if(ageGroup == "22-26")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 49;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 50;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 51;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 52;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 53;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 54;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 55;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 56;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 57;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 36 && runScoreSec >= 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 14)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "27-31")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 58;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 59;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 60;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 61;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 62;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 63;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 64;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 65;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 66;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 100;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 42 && runScoreSec >= 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 14)
                            {
                                r = 100;
                            }
                        }
                        else if(ageGroup == "32-36")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 67;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 68;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 69;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 70;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 71;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 72;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 73;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 16 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 15 && runScoreSec <= 54 && runScoreSec > 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 14)
                            {
                                r = 100;
                            }
                           
                        }
                        else if(ageGroup == "37-41")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 74;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 75;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 76;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 77;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 78;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 16)
                            {
                                r = 100;
                            }
                            
                        }
                        else if(ageGroup == "42-46")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 79;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 80;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 24 && runScoreSec >=0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <= 16)
                            {
                                r = 100;
                            }
                           
                        }
                        else if(ageGroup == "47-51")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 81;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 82;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 83;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 84;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 85;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 86;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 18 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 17 && runScoreSec <= 36 && runScoreSec >=0)
                            {
                                r = 100;
                            }
                            else if (runScoreMin <=16)
                            {
                                r = 100;
                            }
                        }
                        else if( ageGroup == "52-56")
                        {
                            if (runScoreMin >= 21)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec > 42)
                            {
                                r = 0;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 87;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 88;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 89;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 90;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 91;
                            }
                            else if (runScoreMin == 20 && runScoreSec <= 6 && runScoreSec >= 0)
                            {
                                r = 92;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 59 && runScoreSec > 54)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 54 && runScoreSec > 48)
                            {
                                r = 93;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 48 && runScoreSec > 42)
                            {
                                r = 94;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 42 && runScoreSec > 36)
                            {
                                r = 95;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 36 && runScoreSec > 30)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 30 && runScoreSec > 24)
                            {
                                r = 96;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 24 && runScoreSec > 18)
                            {
                                r = 97;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 18 && runScoreSec > 12)
                            {
                                r = 98;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 12 && runScoreSec > 6)
                            {
                                r = 99;
                            }
                            else if (runScoreMin == 19 && runScoreSec <= 6 && runScoreSec > 0)
                            {
                                r = 99;
                            }
                            else if (runScoreMin <= 18)
                            {
                                r = 100;
                            }
                           
                        }
                    }
                    else
                    {
                        
                    }
                }
            }

        }
        //calculate body fat %
        private void calcFat(string gender, double height, double neck, double waist)
        {
            if(gender3 == "Male")
            {
                maleFat = ((86.010 * Math.Log10(waist - neck)) - (70.041 * Math.Log10(height)) + 36.76);
            }
            else if (gender3 == "Female")
            {
                femFat = ((163.205 * Math.Log10(waist + hip - neck)) - (97.684 * Math.Log10(height)) - 78.387);
            }
            else
            {

            }
        }
        //initialize a method for our spinner1 to use
        private void spinner1_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner1 = (Spinner)sender;
            gender = string.Format(""+spinner1.GetItemAtPosition(e.Position));
        }
        //initialize a method for our spinner2 to use
        private void spinner2_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner2 = (Spinner)sender;
            ageGroup = string.Format("" + spinner2.GetItemAtPosition(e.Position));
        }
        //initialize a method for our spinner3 to use
        private void spinner3_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner3 = (Spinner)sender;
            gender3 = string.Format("" + spinner3.GetItemAtPosition(e.Position));
        }

        //creates and runs everything
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            //initialize text view for pushup results
            //set up tabs container
            TabHost t1 = FindViewById<TabHost>(Resource.Id.tabHost);
            t1.Setup();

            //setup tab 1
            TabHost.TabSpec tab1 = t1.NewTabSpec("APFT Calculator");
            tab1.SetContent(Resource.Id.tab1);
            tab1.SetIndicator("APFT Calculator");
            t1.AddTab(tab1);

            //setup tab 2
            TabHost.TabSpec tab2 = t1.NewTabSpec("Saved Scores");
            tab2.SetContent(Resource.Id.tab2);
            tab2.SetIndicator("Saved Scores");
            t1.AddTab(tab2);

            //setup tab 3
            TabHost.TabSpec tab3 = t1.NewTabSpec("Body Fat Calculator");
            tab3.SetContent(Resource.Id.tab3);
            tab3.SetIndicator("Body Fat Calculator");
            t1.AddTab(tab3);

            ScrollView s1 = FindViewById<ScrollView>(Resource.Id.scrollView1);
            ScrollView s2 = FindViewById<ScrollView>(Resource.Id.scrollView2);
            ScrollView s3 = FindViewById<ScrollView>(Resource.Id.scrollView3);

            //initialize our first drop down box
            Spinner spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner1_ItemSelected);
            var adapter1 = ArrayAdapter.CreateFromResource(this, Resource.Array.genderArray, Android.Resource.Layout.SimpleSpinnerItem);
            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter1;

            //initialize our second drop down box
            Spinner spinner2 = FindViewById<Spinner>(Resource.Id.spinner2);
            spinner2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner2_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(this, Resource.Array.ageArray, Android.Resource.Layout.SimpleSpinnerItem);
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter2;

            //initilize body fat drop down box
            Spinner spinner3 = FindViewById<Spinner>(Resource.Id.spinner3);
            spinner3.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner3_ItemSelected);
            var adapter3 = ArrayAdapter.CreateFromResource(this, Resource.Array.genderArray, Android.Resource.Layout.SimpleSpinnerItem);
            adapter3.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner3.Adapter = adapter3;

            //initialize our pushup field
            var edText1 = FindViewById<EditText>(Resource.Id.editText1);
            var text1 = FindViewById<EditText>(Resource.Id.editText1).Text;
            edText1.TextChanged += (object sender, Android.Text.TextChangedEventArgs e1) => 
            {
                if(e1.Text.ToString() == "")
                {
                }
                else if (e1.Text.ToString().Contains(",") == true || e1.Text.ToString().Contains("-") == true || e1.Text.ToString().Contains(".") == true)
                {
                }
                else
                {
                    pushups = Convert.ToInt32(e1.Text.ToString());
                }
            };

            //initialize our situp field
            var edText2 = FindViewById<EditText>(Resource.Id.editText2);
            var text2 = FindViewById<EditText>(Resource.Id.editText2).Text;
            edText2.TextChanged += (object sender, Android.Text.TextChangedEventArgs e2) =>
            {
                if (e2.Text.ToString() == "")
                {
                }
                else if (e2.Text.ToString().Contains(",") == true || e2.Text.ToString().Contains("-") == true || e2.Text.ToString().Contains(".") == true)
                {
                }
                else
                {
                    situps = Convert.ToInt32(e2.Text.ToString());
                }
            };

            //initialize our run time field
            var edText3 = FindViewById<EditText>(Resource.Id.editText3);
            var text3 = FindViewById<EditText>(Resource.Id.editText3).Text;
            edText3.TextChanged += (object sender, Android.Text.TextChangedEventArgs e3) =>
            {
                if (e3.Text.ToString() == "")
                {
                    
                }
                else if (e3.Text.ToString().Contains(",") == true || e3.Text.ToString().Contains("-") == true || e3.Text.ToString().Contains(".") == true)
                {
                }
                else
                {
                    run = e3.Text.ToString();
                }
            };
            
            //initialize our soldier name field(for later saving)
            EditText edText4 = FindViewById<EditText>(Resource.Id.editText4);
            edText4.TextChanged += (object sender, Android.Text.TextChangedEventArgs e4) =>
            {
                if (e4.Text.ToString() == "")
                {

                }
                else if (e4.Text.ToString().Contains(",")==true || e4.Text.ToString().Contains("-") == true || e4.Text.ToString().Contains(".")== true)
                {

                }
                else
                {
                    soldier = e4.Text.ToString();
                }
            };

            //initialize our body fat age
            var tab3edText1 = FindViewById<EditText>(Resource.Id.tab3ed1);
            var t3e1Text = FindViewById<EditText>(Resource.Id.tab3ed1).Text;
            tab3edText1.TextChanged += (object sender, Android.Text.TextChangedEventArgs e5) =>
            {
                if (e5.Text.ToString() == "")
                {
                }
                else if (e5.Text.ToString().Contains(",") == true || e5.Text.ToString().Contains("-") == true || e5.Text.ToString().Contains(".") == true)
                {
                }
                else
                {
                    age3 = Convert.ToDouble(e5.Text.ToString());
                }
            };

            //initialize our body fat height
            var tab3edText2 = FindViewById<EditText>(Resource.Id.tab3ed2);
            var t3e2Text = FindViewById<EditText>(Resource.Id.tab3ed2).Text;
            tab3edText2.TextChanged += (object sender, Android.Text.TextChangedEventArgs e6) =>
            {
                if (e6.Text.ToString() == "")
                {
                }
                else if (e6.Text.ToString().Contains(",") == true || e6.Text.ToString().Contains("-") == true)
                {
                }
                else
                {
                    height = Convert.ToDouble(e6.Text.ToString());
                }
            };

            //initialize our body fat neck
            var tab3edText3 = FindViewById<EditText>(Resource.Id.tab3ed3);
            var t3e3Text = FindViewById<EditText>(Resource.Id.tab3ed3).Text;
            tab3edText3.TextChanged += (object sender, Android.Text.TextChangedEventArgs e7) =>
            {
                if (e7.Text.ToString() == "")
                {
                }
                else if (e7.Text.ToString().Contains(",") == true || e7.Text.ToString().Contains("-") == true)
                {
                }
                else
                {
                    neck = Convert.ToDouble(e7.Text.ToString());
                }
            };

            //intialize our body fat waist
            var tab3edText4 = FindViewById<EditText>(Resource.Id.tab3ed4);
            var t3e4Text = FindViewById<EditText>(Resource.Id.tab3ed4).Text;
            tab3edText4.TextChanged += (object sender, Android.Text.TextChangedEventArgs e8) =>
            {
                if (e8.Text.ToString() == "")
                {
                }
                else if (e8.Text.ToString().Contains(",") == true || e8.Text.ToString().Contains("-") == true)
                {
                }
                else
                {
                    waist = Convert.ToDouble(e8.Text.ToString());
                }
            };

            //initialize our body fat hip
            var tab3edText5 = FindViewById<EditText>(Resource.Id.tab3ed5);
            var t3e5Text = FindViewById<EditText>(Resource.Id.tab3ed5).Text;
            tab3edText5.TextChanged += (object sender, Android.Text.TextChangedEventArgs e9) =>
            {
                if (e9.Text.ToString() == "")
                {
                }
                else if (e9.Text.ToString().Contains(",") == true || e9.Text.ToString().Contains("-") == true)
                {
                }
                else
                {
                    hip = Convert.ToDouble(e9.Text.ToString());
                }
            };

            TextView textView7 = FindViewById<TextView>(Resource.Id.textView7);
            TextView textView8 = FindViewById<TextView>(Resource.Id.textView8);
            TextView textView9 = FindViewById<TextView>(Resource.Id.textView9);
            TextView textView10 = FindViewById<TextView>(Resource.Id.textView10);
            TextView tab3text1 = FindViewById<TextView>(Resource.Id.tab3text1);
            TextView tab3text2 = FindViewById<TextView>(Resource.Id.tab3text2);
            TextView tab3text3 = FindViewById<TextView>(Resource.Id.tab3text3);
            TextView tab3text4 = FindViewById<TextView>(Resource.Id.tab3text4);
            TextView tab3text5 = FindViewById<TextView>(Resource.Id.tab3text5);
            var tab3text7 = FindViewById<TextView>(Resource.Id.tab3text7);
            var tab3text8 = FindViewById<TextView>(Resource.Id.tab3text8);
            var tab2TextView1 = FindViewById<TextView>(Resource.Id.tab2textView1);
            Button tab2button1 = FindViewById<Button>(Resource.Id.tab2button1);
            Button tab2button2 = FindViewById<Button>(Resource.Id.tab2button2);
            Button tab3button1 = FindViewById<Button>(Resource.Id.tab3button1);

            //Calculate our Soldier's PT Score
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                if (edText1 == null || edText2 == null || edText3 == null)
                {

                }
                else if(edText1 != null || edText2 != null || edText3 != null)
                {
                    try
                    {
                        convertTime(run, this.gender, this.ageGroup);
                    }
                    catch
                    {
                    }
                    try
                    {
                        calculateScore(this.gender, this.ageGroup);
                    }
                    catch
                    {
                    }
                    textView7.Text = "Pushups = " + p;
                    textView8.Text = "Situps = " + s;
                    textView9.Text = "Run = " + r;
                    textView10.Text = "Final Score = " + score;
                    soldierStats = ("Soldier : " + soldier +"\n"+ " Pushups : " + p +"\n"+ " Situps : " + s +"\n"+ " Run: " + r +"\n"+ " Final Score : " + score + " ");

                }
                else
                {

                }
                
            };

            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate
            {
                for(int i = 0; i<savedResults.Length; i++)
                {
                    if(savedResults[i] == null)
                    {
                        savedResults[i] = soldierStats;
                        break;
                    }
                    else
                    {

                    }
                }
            };
            tab2button1.Click += delegate
            {
                for (int i = 0; i < savedResults.Length; i++)
                {
                    if (savedResults[i] != null)
                    {
                        tab2TextView1.Text += ("" + savedResults[i] + "\n");
                    }
                    else
                    {

                    }
                }
            };
            tab2button2.Click += delegate
            {
                tab2TextView1.Text = "";
            };
            tab3button1.Click += delegate
            {
                if (gender3 == "Male")
                {
                    if (tab3edText1 == null || tab3edText2 == null || tab3edText3 == null || tab3edText4 == null)
                    {

                    }
                    else if (tab3edText1 != null || tab3edText2 != null || tab3edText3 != null || tab3edText4 != null)
                    {
                        try
                        {
                            calcFat(gender3, this.height, this.neck, this.waist);
                        }
                        catch
                        {
                        }
                        tab3text7.Text = Math.Round(maleFat,2).ToString() + "%";
                        if(age3<17)
                        {
                            tab3text8.Text = "";
                        }
                        else if (age3 >17 && age3 <=20)
                        {
                            tab3text8.Text = "Passing for Males between 17 & 20 is <20%";
                        }
                        else if(age3 >20 && age3 <=27)
                        {
                            tab3text8.Text = "Passing for Males between 21 & 27 is <22%";
                        }
                        else if(age3 >27 && age3 <=39)
                        {
                            tab3text8.Text = "Passing for Males between 28 & 39 is <24%";
                        }
                        else if(age3 >39)
                        {
                            tab3text8.Text = "Passing for Males 40 or older is <26%";
                        }
                        else
                        {
                            tab3text8.Text = "";
                        }
                    }
                }
                else if(gender3 == "Female")
                {
                    if (tab3edText1 == null || tab3edText2 == null || tab3edText3 == null || tab3edText4 == null || tab3edText5 == null)
                    {

                    }
                    else if (tab3edText1 != null || tab3edText2 != null || tab3edText3 != null || tab3edText4 != null || tab3edText5 != null)
                    {
                        try
                        {
                            calcFat(gender3, this.height, this.neck, this.waist);
                        }
                        catch
                        {
                        }
                        tab3text7.Text = Math.Round(femFat,2).ToString() + "%";
                        if (age3 < 17)
                        {
                            tab3text8.Text = "";
                        }
                        else if (age3 > 17 && age3 <= 20)
                        {
                            tab3text8.Text = "Passing for Females between 17 & 20 is <30%";
                        }
                        else if (age3 > 20 && age3 <= 27)
                        {
                            tab3text8.Text = "Passing for Males between 21 & 27 is <32%";
                        }
                        else if (age3 > 27 && age3 <= 39)
                        {
                            tab3text8.Text = "Passing for Males between 28 & 39 is <34%";
                        }
                        else if (age3 > 39)
                        {
                            tab3text8.Text = "Passing for Males 40 or older is <36%";
                        }
                        else
                        {
                            tab3text8.Text = "";
                        }
                    }
                }
                else
                {

                }
                

            }; 
       }
    }
}

