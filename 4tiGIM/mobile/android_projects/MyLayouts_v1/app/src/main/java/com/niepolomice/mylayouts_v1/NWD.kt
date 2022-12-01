package com.niepolomice.mylayouts_v1

class NWD {
    public  fun NWDRec(a:Int,b:Int):Int{
        if(b==0) return a;
        else return NWDRec(b,a%b);
    }
}