!function(t){function e(){$("h1, h2").each(function(){var t=$(this),e=t.nextUntil("h1, h2");c.add({id:t.prop("id"),title:t.text(),body:e.text()})})}function i(){a=$(".content"),r=$(".dark-box"),l=$(".search-results"),$("#input-search").on("keyup",s)}function s(t){if(o(),l.addClass("visible"),27===t.keyCode&&(this.value=""),this.value){var e=c.search(this.value).filter(function(t){return t.score>1e-4});e.length?(l.empty(),$.each(e,function(t,e){l.append("<li><a href='#"+e.ref+"'>"+$("#"+e.ref).text()+"</a></li>")}),n.call(this)):(l.html("<li></li>"),$(".search-results li").text('No Results Found for "'+this.value+'"'))}else o(),l.removeClass("visible")}function n(){this.value&&a.highlight(this.value,h)}function o(){a.unhighlight(h)}var a,r,l,h=($(t),{element:"span",className:"search-highlight"}),c=new lunr.Index;c.ref("id"),c.field("title",{boost:10}),c.field("body"),c.pipeline.add(lunr.trimmer,lunr.stopWordFilter),$(e),$(i)}(window);