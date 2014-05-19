var text = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";
var regex = /(<([^>]+)>)/ig;
var result = text.replace(regex, "");
console.log(result);