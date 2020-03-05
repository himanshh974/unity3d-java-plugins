import android.content.Context;
import android.os.Looper;
import android.os.Handler;
import android.widget.Toast;

public class Ble  {
   public void PrintString(final Context ctx, final String message){

     new Handler(Looper.getMainLooper()).post(new Runnable(){
         @Override
         public  void run(){
             Toast.makeText(ctx, message, Toast.LENGTH_SHORT).show();
         }
       });
   }
}
