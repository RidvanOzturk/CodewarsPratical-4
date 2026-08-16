static int bouncingBall(double h, double bounce, double window)
{
    double down = 0;
    int count = 0;
    down = h * bounce;
    if (h > 0 && bounce > 0 && bounce < 1 && window < h)
    {
        count++;

        down = 0;
        do
        {
            down = h * bounce;
            if (down > window)
            {
                count+=2;
            }
            h = down;

        } while (down > window);
    }
    else
    {
        return -1;
    }
 
    return count;
}

Console.WriteLine(bouncingBall(30.0, 0.66, 1.5));