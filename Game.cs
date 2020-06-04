using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key, out int xChange, out int yChange)
    {
      switch (key)
      {
        case "DownArrow":
          xChange = 0;
          yChange = 1;
          break;

        case "UpArrow":
          xChange = 0;
          yChange = -1;
          break;

        case "LeftArrow":
          xChange = -1;
          yChange = 0;
          break;

        case "RightArrow":
          xChange = 1;
          yChange = 0;
          break;

        default:
          xChange = 0;
          yChange = 1;
          break;
      }
    }

    public new static char UpdateCursor(string key)
    {
      switch (key)
      {
        case "DownArrow":
          return 'v';

        case "UpArrow":
          return '^';

        case "LeftArrow":
          return '<';

        case "RightArrow":
          return '>';

        default:
          return '^';
      }
    }

    public new static int KeepInBounds(int coordinate, int max)
    {
      if (coordinate < 0)
      {
        return max - 1;
      }
      if (coordinate >= max)
      {
        return 0;
      }

      return coordinate;
    }

    public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
    {
      if ((charX == fruitX) && (charY == fruitY))
      {
        return true;
      }
      return false;
    }
  }
}
