<template>
  <section>
    <div class="container">
      <div class="p-4 p-md-5 text-white rounded bg-dark">
        <!-- <h1 class="display-4 fst-italic">Title of a longer featured blog post</h1> -->

        <table class="table text-white" v-if="!loadingdata">
          <thead>
            <tr>
              <th>№ Заявки</th>
              <th>Номер тлф</th>
              <th>ФИО</th>
              <th>E-mail</th>
              <th>Сумма</th>
              <th>Срок займа</th>
              <th>Дата заявки</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="user in paginationuser" :key="user.index">
              <!-- <td>{{ user.id }}</td> -->
              <td>{{ user.requestnumber }}</td>
              <td>{{ user.inputtel }}</td>
              <td>{{ user.inputname }}</td>
              <td>{{ user.inputemail }}</td>
              <td>{{ user.vmodelsumm }}</td>
              <td>{{ user.vmodelday }}</td>

              <td>{{ user.datenow }}</td>
            </tr>
            <!-- <tr>
              <td>Charlie</td>
              <td>7</td>
              <td>9</td>
              <td>9</td>
              <td>9</td>
              <td>9</td>
              <td>9</td>
            </tr> -->
          </tbody>
          <!-- <tfoot>
            <tr>
              <td>Totals</td>
              <td>21</td>
              <td>23</td>
            </tr>
          </tfoot> -->
        </table>
        <h1 class="display-4 fst-italic" v-else>loading data.......</h1>
      </div>
    </div>
    <!-- pagination -->
    <nav aria-label="Page navigation example">
      <ul class="pagination container d-block">
        <li class="page-item"><a class="page-link" href="#">Previous</a></li>
        <li
          class="page-item mypage"
          v-for="pagenumber in totalpage"
          :key="pagenumber"
          :class="{ 'active': mypage == pagenumber }"
          @click="pageclick(pagenumber)"
        >
          <a class="page-link" href="#"> {{ pagenumber }} </a>
        </li>
        <li class="page-item"><a class="page-link" href="#">Next</a></li>
      </ul>
    </nav>
    <div class="">
      <button class="" @click="clicklog">clcickckckkc</button>
    </div>
  </section>
</template>

<script>
import axios from "axios";
// import bootstrap from "bootstrap";
export default {
  data: () => ({
    users: [],
    // paginationuserr: [],
    page: 1,
    limit: 10,
    // totalpage: 0,
    loadingdata: true,
    pagenumber: 1,
  }),
  computed: {
    totalpage() {
      return Math.ceil(this.users.length / this.limit);
    },
    paginationuser() {
      let from = (this.pagenumber - 1) * this.limit;
      let to = from + this.limit;
      return this.users.slice(from, to);
    },
  },
  methods: {
    pageclick(page) {
      this.pagenumber = page;
    },
    getdatafromapi() {
      // this.loadingdata = true;
      axios
        .get("api/Settings/List", { responseType: "json" })
        .then((Response) => {
          console.log("responseType");
          console.log(Response);
          console.log("responsedata");

          console.log(Response.data);
          // if (Response.data.legth)
          this.users = Response.data;
          // this.users = Object.assign({}, this.obj);
          //   console.log("data arrived");
          this.loadingdata = false;
        })

        .catch((error) => {
          console.error(error + "err");
        })
        .finally(() => {});
    },
    clicklog() {
      console.log(this.user);
      console.log(this.users);
      console.log(this.totalpage);
      console.log(this.page);
    },
  },
  mounted() {
    this.getdatafromapi();
  },
};
</script>

<style>
/* .page-item {
  padding: auto;
  flex-basis: 25%;
  text-align: left;
} */
.mypage {
  padding: auto;
  /* flex-basis: 25%;
  text-align: left; */
}
</style>
