using System.Xml.Serialization;
#region Header

Console.WriteLine("\n\t***   WELCOME TO V#TECH   ***");

#endregion Header

#region VariableDeclaration
string? fName = null, mName = null, lName = null, fName2 = null, mName2 = null, lName2 = null, CourceDisplay = null, Op1 = null, SiExit = null, AFExit = null;
string UserName2, Password2;
int? BalFee = null, PaidFee = null, CourceId = null, PaidFee1 = null, BalFee1 = null;
string? UserName = null, Password = null, UserName3 = null, Password3 = null, Choice = null, CourceConfirm = null;
int TotalFeeDN = 50000, TotalFeeHC = 10000, TotalFeeCS = 20000, TotalFeeSQL = 30000;
int option = 0, CourceDisplayOp = 0;
#endregion VariableDeclaration

do
{
    #region Options
    Console.WriteLine("\n* CHOOSE FROM *");
    Console.WriteLine("1    :   SIGN UP");
    Console.WriteLine("2    :   LOGIN");
    Console.WriteLine("3    :   ADDMISSION");
    Console.WriteLine("4    :   PAYMENT");
    Console.WriteLine("5    :   FEE RECEIPT");
    Console.WriteLine("0    :   EXIT");
    Console.Write("\nCHOOSE OPTIONS:");
    option = Convert.ToInt32(Console.ReadLine());
    #endregion Options

    switch (option)
    {

        #region SignUpPage
        case 1:
            Console.WriteLine("\t________________________");
            Console.WriteLine("\tWELCOME TO SIGN UP PAGE:");
            do
            {
                Console.Write("\nEnter First Name: ");
                fName = Console.ReadLine();
                Console.Write("Enter Middle Name: ");
                mName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                lName = Console.ReadLine();
                Console.Write("\nCreate Username: ");
                UserName = Console.ReadLine();
                Console.Write("Create Password: ");
                Password = Console.ReadLine();
                Console.Write("\n!!! IF YOU WANT TO EDIT TYPE (YES) OTHERWISE (NO): ");
                SiExit = Console.ReadLine();

            } while (SiExit == "YES" || SiExit == "Yes" || SiExit == "yes");


            Console.WriteLine("\t_________________________________");
            Console.WriteLine("\t* ACCOUNT CREATED SUCCESSFULLY *");
            Console.WriteLine("\t_________________________________");

            break;
        #endregion SignUpPage

        #region LoginPage
        case 2:

            Console.WriteLine("\t________________________");
            Console.WriteLine("\tWELCOME TO LOGIN PAGE:\n");
            do
            {
                Console.Write("Enter Username: ");
                UserName2 = Console.ReadLine();
                Console.Write("Enter Password: ");
                Password2 = Console.ReadLine();
                if (UserName2 != UserName || Password2 != Password)
                {
                    Console.WriteLine("\n\t!!!! INCORRECT USERNAME OR PASSWORD !!!!");
                    Console.WriteLine("\t\t!!!! TRY AGAIN !!!!\n");
                }
                else
                {
                    Console.WriteLine("\t__________________________");
                    Console.WriteLine("\t* LOGIN SUCCESSFULLY  *");
                    Console.WriteLine("\t________________________");

                }


            } while (UserName2 != UserName || Password2 != Password);

            break;
        #endregion LoginPage

        #region AdmissionForm
        case 3:
            Console.WriteLine($"\t________________________");
            Console.WriteLine("\t** FILL ADMISSION FORM **\n");

            do
            {
                Console.Write("Enter First Name: ");
                fName2 = Console.ReadLine();
                Console.Write("Enter Middle Name: ");
                mName2 = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                lName2 = Console.ReadLine();

                Console.Write("\n!!! IF YOU WANT TO EDIT TYPE (YES) OTHERWISE (NO): ");
                AFExit = Console.ReadLine();
            } while (AFExit == "YES" || AFExit == "yes" || AFExit == "Yes");


            Console.WriteLine("\nTO DISPLAY ALL AVAILABLE COURCE TYPE : YES");
            CourceDisplay = Console.ReadLine();

            if (CourceDisplay == "Yes" || CourceDisplay == "YES" || CourceDisplay == "yes")
            {
                Console.WriteLine("\t: COURCE DETAILS :\n");
                Console.WriteLine("ID |\tCOURCE NAME |\tCOURCE FEE |\tTEACHER");
                Console.WriteLine("1 \tHTML & CSS \t10,000 \t\tMRS.USHA RATHOD");
                Console.WriteLine("2 \tSQL \t\t30,000 \t\tMR.VIKUL RATHOD");
                Console.WriteLine("3 \tCSHARP \t\t20,000 \t\tMR.RUSHIKESH THORAT");
                Console.WriteLine("4 \tDOT NET CORE \t50,000 \t\tMRS.AMRUTA THORAT");
                do
                {

                    Console.Write("\nENTER COURCE ID TO SELECT : ");
                    CourceDisplayOp = Convert.ToInt32(Console.ReadLine());
                    CourceId = CourceDisplayOp;

                    switch (CourceDisplayOp)
                    {
                        case 1:
                            {
                                Console.WriteLine("\t\t!!!!!!");
                                Console.WriteLine($"You select HTML & CSS Cource, Total fee is 10,000 ");
                                Console.WriteLine($"For this cource MRS.USHA RATHOD  will be assign.");
                                Console.WriteLine($"\t________________________");
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("\t\t!!!!!!");
                                Console.WriteLine($"You select SQL Cource, Total fee is 30,000 ");
                                Console.WriteLine($"For this cource MR.VIKUL RATHOD  will be assign.");
                                Console.WriteLine($"\t________________________");
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("\t\t!!!!!!");
                                Console.WriteLine($"You select CSHARP Cource, Total fee is 20,000 ");
                                Console.WriteLine($"For this cource MR.RUSHIKESH THORAT  will be assign.");
                                Console.WriteLine($"\t________________________");
                            }
                            break;

                        case 4:
                            {
                                Console.WriteLine("\t\t!!!!!!");
                                Console.WriteLine($"You select DOT NET CORE Cource, Total fee is 50,000 ");
                                Console.WriteLine($"For this cource MRS.AMRUTA THORAT  will be assign.");
                                Console.WriteLine($"\t________________________");
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("\n\t!!! PLEASE ENTER VALID COURCE ID !!!\n");
                            }
                            break;
                    }
                    Console.Write("\t\nIF YOU WANT TO CHANGE COURCE: TYPE (YES)\n\t OTHERWISE: TYPE (NO) : ");
                    CourceConfirm = Console.ReadLine();


                } while (CourceConfirm == "Yes" || CourceConfirm == "yes" || CourceConfirm == "YES");

            }

            else
            {
                Console.WriteLine("\n\t!!! YOU DOESNT CHOOSE ANY COURCE !!!\n");
            }

            break;
        #endregion AdmissionForm

        #region PaymentPage
        case 4:

            Console.WriteLine($"\t____________________________");
            Console.WriteLine("\t** WELCOME TO PAYMENT PAGE **\n");
            do
            {
                if (CourceId == 1)
                {
                    Console.WriteLine($"HTML & CSS COURCE FEE IS : {TotalFeeHC}");
                    Console.Write("\nEnter Amount you want to pay : ");
                    PaidFee = Convert.ToInt32(Console.ReadLine());



                    if (PaidFee > TotalFeeHC || PaidFee <= 0)
                    {
                        Console.WriteLine("\n\t!!! PLEASE CHECK PAID AMOUNT !!!\n");
                    }

                    else
                    {
                        BalFee = TotalFeeHC - PaidFee;
                        Console.WriteLine($"\nYour Remaining Amount: {BalFee} ");
                    }
                    PaidFee1 = PaidFee;
                    BalFee1 = BalFee;



                }

                else if (CourceId == 2)
                {
                    Console.WriteLine($"SQL COURCE FEE IS : {TotalFeeSQL}");
                    Console.Write("\nEnter Amount you want to pay : ");
                    PaidFee = Convert.ToInt32(Console.ReadLine());

                    if (PaidFee > TotalFeeSQL || PaidFee <= 0)
                    {
                        Console.WriteLine("\n\t!!! PLEASE CHECK PAID AMOUNT !!!\n");
                    }

                    else
                    {
                        BalFee = TotalFeeSQL - PaidFee;
                        Console.WriteLine($"\nYour Remaining Amount: {BalFee} ");
                    }
                    PaidFee1 = PaidFee;
                    BalFee1 = BalFee;


                }

                else if (CourceId == 3)
                {
                    Console.WriteLine($"CSHARP COURCE FEE IS : {TotalFeeCS}");
                    Console.Write("\nEnter Amount you want to pay : ");
                    PaidFee = Convert.ToInt32(Console.ReadLine());

                    if (PaidFee > TotalFeeCS || PaidFee <= 0)
                    {
                        Console.WriteLine("\n\t!!! PLEASE CHECK PAID AMOUNT !!!\n");
                    }

                    else
                    {
                        BalFee = TotalFeeCS - PaidFee;
                        Console.WriteLine($"\nYour Remaining Amount: {BalFee} ");
                    }
                    PaidFee1 = PaidFee;
                    BalFee1 = BalFee;
                }

                else
                {
                    Console.WriteLine($"DOT NET CORE COURCE FEE IS : {TotalFeeDN}");
                    Console.Write("\nEnter Amount you want to pay : ");
                    PaidFee = Convert.ToInt32(Console.ReadLine());

                    if (PaidFee > TotalFeeDN || PaidFee <= 0)
                    {
                        Console.WriteLine("\n\t!!! PLEASE CHECK PAID AMOUNT !!!\n");
                    }

                    else
                    {
                        BalFee = TotalFeeDN - PaidFee;
                        Console.WriteLine($"\nYour Remaining Amount: {BalFee} ");
                    }
                    PaidFee1 = PaidFee;
                    BalFee1 = BalFee;
                }

                Console.WriteLine("\t\nIF YOU WANT TO CHANGE AMOUNT: TYPE (YES)\n\t OTHERWISE: TYPE (NO)");
                Op1 = Console.ReadLine();


            } while (Op1 == "YES" || Op1 == "yes" || Op1 == "Yes");
            break;
        #endregion PaymentPage

        #region DownloadPage
        case 5:

            Console.WriteLine("\t___________________________");
            Console.WriteLine("\t# For Downloding Receipt #\n");

            do
            {
                Console.Write("Enter Username : ");
                UserName3 = Console.ReadLine();
                Console.Write("Enter Password : ");
                Password3 = Console.ReadLine();

                if (UserName3 == UserName && Password3 == Password)
                {
                    Console.WriteLine("\t_____________________________________");
                    Console.WriteLine("\tVALID USER !!! STARTING DOWNLOADING");
                    Console.WriteLine("\t_____________________________________");
                }

                else
                {
                    Console.WriteLine("\t_____________________________________");
                    Console.WriteLine("\tINVALID USER !!! TRY AGIAN");
                    Console.WriteLine("\t_____________________________________");
                }
            } while (UserName3 != UserName || Password3 != Password);
            #endregion DownloadPage

            #region ViewRecipt
            do
            {
                Console.WriteLine("\t_____________________________________");
                Console.WriteLine("\tFOR VIEW YOUR RECEIPT TYPE : YES");
                Console.WriteLine("\tOTHERWISE : TYPE ANY KEY");
                Console.WriteLine("\t_____________________________________");
                Choice = Console.ReadLine();

                if (Choice == "YES" || Choice == "yes" || Choice == "Yes")
                {

                    DateTime current = DateTime.Now;
                    string onlyDate = current.ToString("dd MMMM yyyy");
                    string onlyTime = current.ToShortTimeString();

                    if (CourceId == 1)
                    {
                        Console.WriteLine("\t______________________________");
                        Console.WriteLine("\t* FEE RECEIPT OF ADMISSION *");
                        Console.WriteLine($"      {fName2.ToUpper()} {mName2.ToUpper()} {lName2.ToUpper()} TAKING ADMISSION IN V#TECH INSTITUDE \nFOR HTML & CSS COURCE ON {onlyDate} {onlyTime}");
                        Console.WriteLine($"PAID FEE: {PaidFee1} AND BALANCE FEE: {BalFee1}");
                        Console.WriteLine("\t______________________________");

                    }
                    else if (CourceId == 2)
                    {
                        Console.WriteLine("\t______________________________");
                        Console.WriteLine("\t* FEE RECEIPT OF ADMISSION *");
                        Console.WriteLine($"      {fName2.ToUpper()} {mName2.ToUpper()} {lName2.ToUpper()} TAKING ADMISSION IN V#TECH INSTITUDE \nFOR SQL COURCE ON {onlyDate} {onlyTime}");
                        Console.WriteLine($"PAID FEE: {PaidFee1} AND BALANCE FEE: {BalFee1}");
                        Console.WriteLine("\t______________________________");


                    }

                    else if (CourceId == 3)
                    {
                        Console.WriteLine("\t______________________________");
                        Console.WriteLine("\t* FEE RECEIPT OF ADMISSION *");
                        Console.WriteLine($"      {fName2.ToUpper()} {mName2.ToUpper()} {lName2.ToUpper()} TAKING ADMISSION IN V#TECH INSTITUDE \nFOR CSHARP COURCE ON {onlyDate} {onlyTime}");
                        Console.WriteLine($"PAID FEE: {PaidFee1} AND BALANCE FEE: {BalFee1}");
                        Console.WriteLine("\t______________________________");

                    }

                    else
                    {
                        Console.WriteLine("\t______________________________");
                        Console.WriteLine("\t* FEE RECEIPT OF ADMISSION *");
                        Console.WriteLine($"      {fName2.ToUpper()} {mName2.ToUpper()} {lName2.ToUpper()} TAKING ADMISSION IN V#TECH INSTITUDE \nFOR DOT NET CORE COURCE ON {onlyDate} {onlyTime}");
                        Console.WriteLine($"PAID FEE: {PaidFee1} AND BALANCE FEE: {BalFee1}");
                        Console.WriteLine("\t______________________________");

                    }


                }


            } while (Choice == "NO" || Choice == "No" || Choice == "no");

            break;
        #endregion ViewRecipt

        #region default
        default:

            Console.WriteLine("\t!!! PLEASE ENTER VALID OPTION !!!\n");
            break;
            #endregion default

    }

} while (option != 0);
Console.ReadLine();
