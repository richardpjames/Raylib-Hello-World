using Raylib_cs;

namespace HelloWorld;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(1920, 1080, "Hello World");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.White);

            Raylib.DrawText("Hello, world!", 12, 12, 64, Color.DarkGray);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}