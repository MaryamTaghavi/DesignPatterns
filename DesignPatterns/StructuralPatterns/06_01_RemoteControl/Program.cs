/*
 
 مثال ریموت به این شکلی است که دو نوع ریموت مختلف (ساده و پیشرفته) داریم
 که قرار هست دستگاه های مختلف از جمله تلویزیون یا رادیو یا برند های مختلف (سونی و سامسونگ) آنها را منترل کنند.

*/

using _06_01_RemoteControl;

var lgRemoteControl = new RemoteControl(new LGRadio());

lgRemoteControl.TurnOn();
lgRemoteControl.TurnOff();

var advancedSonyControl = new AdvancedRemote(new SonyRadio());

advancedSonyControl.TurnOn();
advancedSonyControl.TurnOff();
advancedSonyControl.SetChannel(2);