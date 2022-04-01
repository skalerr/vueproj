import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store/index";
import "bootstrap/dist/js/bootstrap.bundle.min";
// import slider from "./trash/slider";
import "animate.css";
// import axios from "axios";
// import dateFilter from "./components/filters/date.filter"

// font awsome import
import { library } from "@fortawesome/fontawesome-svg-core";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import { fas } from "@fortawesome/free-solid-svg-icons";
library.add(fas);
import { fab } from "@fortawesome/free-brands-svg-icons";
library.add(fab);
import { far } from "@fortawesome/free-regular-svg-icons";
library.add(far);
import { dom } from "@fortawesome/fontawesome-svg-core";
dom.watch();
// axios.defaults.headers.get["header-name"] = "value";
// const cors = require("cors");

createApp(App)
  // .use(slider)
  .use(store)
  .use(router)
  .use("font-awesome-icon", FontAwesomeIcon)
  // .use(cors())
  .mount("#app");
