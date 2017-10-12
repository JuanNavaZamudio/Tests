public class Pi{
//calcula pi usando la serie de wallis
public static void main(String args[]){
	long n=2;
	long d=1;
	double r=1;
	Pi pi= new Pi();
	long c=0;
		//n<int.MAX_VALUE-1 && d<int.MAX_VALUE
	while(c<200000000){
		
		
		r = r * n/d;
		
		if(n>d)
			d=d+2;
		else
			n=n+2;
		
		c++;
	}
	r=r*2;
	
	
	System.out.println(r);

}

}