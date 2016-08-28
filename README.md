# WiringPi.Net
WiringPi's library .NET/Mono Wrapper

This is a simple .NET wrapper around Drogon's great library [WiringPi](http://wiringpi.com). I needed some simple way to use that library in my Mono application runing under RPi's Raspbian and Odroid's Debian and this is it :)

# How to

* Checkout WiringPi library:

	* RaspberryPi: `git clone git://git.drogon.net/wiringPi`
	* Odroid: `git clone https://github.com/hardkernel/wiringPi`

* Build it

```
cd wiringPi
git pull origin
./build
```

* Check if Shared Object Library has been created:

`ls /usr/local/lib/libwiringPi.so`

* Now you can use WiringPi in your .NET/Mono projects, just add reference to WiringPi.NET.dll and you should be good to go.

# Wrapper, OO and Fake

You can use plain wrapper located in `WiringPiNet.Wrapper` namespace or go for object-oriented classes from base namespace. Also if you wish to debug code outside of RPi's board then look on `WiringPiNet.Fake`namespace where you'll find fake wrapper that you can use instead of real one in debug environment (as running real wrapper on Windows will fail due to absence of libwiringPi.so and GPIO infrastructure). 

# PinWatcher

Use PinWatcher class to observe certain pins with given interval. PinWatcher is pooling pins and issues event when anything has changed (value or mode).
