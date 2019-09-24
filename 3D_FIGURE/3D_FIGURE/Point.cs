namespace _3D_FIGURE {
    public class point {
        public float x, y;
        public point(){
            x = 0;
            y = 0;
        }
        public point(float X,float Y) {
            x = X;
            y = Y;

        }
        public void copy(float X, float Y)
        {
            x = X;
            y = Y;

        }
    }

}