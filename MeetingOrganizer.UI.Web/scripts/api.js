$(document).ready(function(){
    $('#toplantilariListele').click(function () {
        $.getJSON('../api/toplanti').done(function(veri){
            var toplantilar="";
            $.each(veri,function(key,toplanti){
                toplantilar+=toplanti.ToplantiKonusu+toplanti.Tarih+toplanti.BaslangicSaati+toplanti.BitisSaati+toplanti.Katilimcilar+"<br/>";
            });
            $('#toplantilar').html(toplantilar);
        })
    });
})