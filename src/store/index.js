import { createStore } from "vuex";
import toast from "./modules/toast.js";
import getsettings from "./modules/getsettings";

export default createStore({
  modules: {
    toast,
    getsettings,
  },
});
