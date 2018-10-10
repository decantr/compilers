using static System.Math;

namespace second {
  internal class Config {
    private object l = new object();
    public int d { get; private set; } = 200;
    public bool f { get; private set; }

    public void SetDone() {
        f = true;
    }

    public void UpdateDelay( int i ) {
      int n = Min( d + i , 1000 );
      n = Max( n , 20 );

      lock ( l ) {
        d = n;
      }
    }
  }
}