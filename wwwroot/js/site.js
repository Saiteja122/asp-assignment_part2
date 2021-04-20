// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function copy_to_clipboard() {
  var copyText = document.getElementsByClassName('title')[0].innerHTML;
  

  copyText = copyText.replace(/\s/g, '');
  // alert("Copied the title : " + copyText);
  
  // copyText.select()

    var dummy = document.createElement("textarea");
    document.body.appendChild(dummy);

    dummy.value = copyText;
    dummy.select();

  document.execCommand("copy");
document.body.removeChild(dummy);
  alert("Copied the title: " + copyText);

  console.log(copyText);
} 