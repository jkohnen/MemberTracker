var config = {
    RootUrl : "http://localhost:1234",
    splashPage : "MemberList.html",
    splashDelayInMilliseconds : 0
    
}

String.prototype.trim=function(){return this.replace(/^\s\s*/, '').replace(/\s\s*$/, '');};
String.prototype.ltrim=function(){return this.replace(/^\s+/,'');};
String.prototype.rtrim=function(){return this.replace(/\s+$/,'');};
String.prototype.fulltrim=function(){return this.replace(/(?:(?:^|\n)\s+|\s+(?:$|\n))/g,'').replace(/\s+/g,' ');}

var ServiceManager = {
    ServiceUrl : function(path) {
     return config.RootUrl + path;
    }
}