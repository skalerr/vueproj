(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["about"],{"19aaf":function(e,t,n){"use strict";n("ddfe")},"1a33":function(e,t,n){"use strict";n.r(t);var c=n("7a23"),a={class:"list"};function l(e,t,n,l,o,r){var i=Object(c["resolveComponent"])("navigation"),s=Object(c["resolveComponent"])("List1");return Object(c["openBlock"])(),Object(c["createElementBlock"])("div",a,[Object(c["createVNode"])(i),Object(c["createVNode"])(s)])}var o=n("a78a"),r={class:"container"},i={class:"p-4 p-md-5 text-white rounded bg-dark"},s={key:0,class:"table text-white"},d=Object(c["createElementVNode"])("thead",null,[Object(c["createElementVNode"])("tr",null,[Object(c["createElementVNode"])("th",null,"№ Заявки"),Object(c["createElementVNode"])("th",null,"Номер тлф"),Object(c["createElementVNode"])("th",null,"ФИО"),Object(c["createElementVNode"])("th",null,"E-mail"),Object(c["createElementVNode"])("th",null,"Сумма"),Object(c["createElementVNode"])("th",null,"Срок займа"),Object(c["createElementVNode"])("th",null,"Дата заявки")])],-1),u={key:1,class:""},b=Object(c["createElementVNode"])("h1",{class:"display-4 fst-italic"},"Error",-1),m=[b],p={key:2,class:""},j=Object(c["createElementVNode"])("h1",{class:"display-4 fst-italic"},"loading data.......",-1),O=Object(c["createElementVNode"])("div",{class:"spinner-border",role:"status"},[Object(c["createElementVNode"])("span",{class:"visually-hidden"},"Loading...")],-1),g=[j,O],f={"aria-label":"Page navigation example"},k={class:"pagination container d-block"},E=["onClick"],h={class:"page-link",href:"#"},v={class:""};function N(e,t,n,a,l,o){return Object(c["openBlock"])(),Object(c["createElementBlock"])("section",null,[Object(c["createElementVNode"])("div",r,[Object(c["createElementVNode"])("div",i,[e.loadingdata?e.loadingdataerror?(Object(c["openBlock"])(),Object(c["createElementBlock"])("div",u,m)):(Object(c["openBlock"])(),Object(c["createElementBlock"])("div",p,g)):(Object(c["openBlock"])(),Object(c["createElementBlock"])("table",s,[d,Object(c["createElementVNode"])("tbody",null,[(Object(c["openBlock"])(!0),Object(c["createElementBlock"])(c["Fragment"],null,Object(c["renderList"])(o.paginationuser,(function(e){return Object(c["openBlock"])(),Object(c["createElementBlock"])("tr",{key:e.index},[Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.requestNumber),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.inputtel),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.inputname),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.inputemail),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.vmodelsumm),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.vmodelday),1),Object(c["createElementVNode"])("td",null,Object(c["toDisplayString"])(e.datenow),1)])})),128))])]))])]),Object(c["createElementVNode"])("nav",f,[Object(c["createElementVNode"])("ul",k,[(Object(c["openBlock"])(!0),Object(c["createElementBlock"])(c["Fragment"],null,Object(c["renderList"])(o.totalpage,(function(t){return Object(c["openBlock"])(),Object(c["createElementBlock"])("li",{class:Object(c["normalizeClass"])(["page-item",{active:e.pagenumber==t}]),key:t,onClick:function(e){return o.pageclick(t)}},[Object(c["createElementVNode"])("a",h,Object(c["toDisplayString"])(t),1)],10,E)})),128))])]),Object(c["createElementVNode"])("div",v,[Object(c["createElementVNode"])("button",{class:"",onClick:t[0]||(t[0]=function(){return o.clicklog&&o.clicklog.apply(o,arguments)})},"clcickckckkc")])])}n("fb6a"),n("d3b7");var V=n("bc3a"),y=n.n(V),B={data:function(){return{users:[],page:1,limit:10,loadingdata:!0,loadingdataerror:!1,pagenumber:1}},computed:{totalpage:function(){return Math.ceil(this.users.length/this.limit)},paginationuser:function(){var e=(this.pagenumber-1)*this.limit,t=e+this.limit;return this.users.slice(e,t)}},methods:{pageclick:function(e){this.pagenumber=e},getdatafromapi:function(){var e=this;y.a.get("api/Settings/List",{responseType:"json"}).then((function(t){console.log("responseType"),console.log(t),console.log("responsedata"),console.log(t.data),e.users=t.data,e.loadingdata=!1}))["catch"]((function(t){e.loadingdataerror=!0,console.error(t+"err")}))["finally"]((function(){}))},clicklog:function(){console.log(this.user),console.log(this.users),console.log(this.totalpage),console.log(this.page)}},mounted:function(){this.getdatafromapi()}},w=(n("19aaf"),n("6b0d")),S=n.n(w);const D=S()(B,[["render",N]]);var L=D,C={name:"List",components:{navigation:o["a"],List1:L}};const x=S()(C,[["render",l]]);t["default"]=x},ddfe:function(e,t,n){},f820:function(e,t,n){"use strict";n.r(t);var c=n("7a23"),a={class:"about"},l=Object(c["createElementVNode"])("h1",null,"This is an about page",-1),o=[l];function r(e,t){return Object(c["openBlock"])(),Object(c["createElementBlock"])("div",a,o)}var i=n("6b0d"),s=n.n(i);const d={},u=s()(d,[["render",r]]);t["default"]=u},fb6a:function(e,t,n){"use strict";var c=n("23e7"),a=n("da84"),l=n("e8b5"),o=n("68ee"),r=n("861d"),i=n("23cb"),s=n("07fa"),d=n("fc6a"),u=n("8418"),b=n("b622"),m=n("1dde"),p=n("f36a"),j=m("slice"),O=b("species"),g=a.Array,f=Math.max;c({target:"Array",proto:!0,forced:!j},{slice:function(e,t){var n,c,a,b=d(this),m=s(b),j=i(e,m),k=i(void 0===t?m:t,m);if(l(b)&&(n=b.constructor,o(n)&&(n===g||l(n.prototype))?n=void 0:r(n)&&(n=n[O],null===n&&(n=void 0)),n===g||void 0===n))return p(b,j,k);for(c=new(void 0===n?g:n)(f(k-j,0)),a=0;j<k;j++,a++)j in b&&u(c,a,b[j]);return c.length=a,c}})}}]);
//# sourceMappingURL=about.99da9db4.js.map