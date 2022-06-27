int distanceWalked(int n)
{
    int totalDistance = n;
    while(0 < n)
    {
        totalDistance += n;
        n--;
    }
    return totalDistance;
}