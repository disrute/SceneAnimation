using System;
using SplashKitSDK;

public class Program
{
    private const string _WelcomeMessage = "Welcome to the batville! Something wicked this way comes";

    public static void Main()
    {
        Window w = new Window("LDenholm Animation", 200, 200);

        Bitmap bat = SplashKit.LoadBitmap("BatBmp", "sheet_bat_fly.png");
        bat.SetCellDetails(32, 32, 4, 1, 4);

        AnimationScript batFly = SplashKit.LoadAnimationScript("BatFlying", "animBat.txt");

        //create animation
        Animation batAnim = batFly.CreateAnimation("Fly");

        DrawingOptions opt;
        opt = SplashKit.OptionWithAnimation(batAnim);

        while(!w.CloseRequested)
        {
            w.Clear(Color.White);
            //w.DrawText(_WelcomeMessage, 
            //Color.Black, 3, 100, 100);
            //SplashKit.Delay(3000);
            w.Clear(Color.White);
            w.DrawBitmap(bat, 64, 64, opt);
            w.Refresh(60);

            //Update
            batAnim.Update();
        }
    }
}
