var ilh = window.location.hostname === 'localhost';
if(!ilh){
  
  //Global site tag (gtag.js) - Google Analytics
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-73407480-1');

  //Hotjar Tracking Code for gvcayetano.com
  (function(h,o,t,j,a,r){
	  h.hj=h.hj||function(){(h.hj.q=h.hj.q||[]).push(arguments)};
	  h._hjSettings={hjid:1458228,hjsv:6};
	  a=o.getElementsByTagName('head')[0];
	  r=o.createElement('script');r.async=1;
	  r.src=t+h._hjSettings.hjid+j+h._hjSettings.hjsv;
	  a.appendChild(r);
  })(window,document,'https://static.hotjar.com/c/hotjar-','.js?sv=');

}