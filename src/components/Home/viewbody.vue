<template>
  <div>
    <!-- MODAL -->
    <div
      class="modal fade"
      id="exampleModal"
      tabindex="-1"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Form</h5>

            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body">
            <form action="">
              <div class="row mb-3">
                <label for="inputEmail" class="col-sm-2 col-from-label">Email</label>
                <div class="col-sm-10">
                  <input type="email" class="form-control" id="inputEmail" />
                </div>
              </div>
              <div class="row mb-3">
                <label for="inputPass" class="col-sm-2 col-from-label">Pass</label>
                <div class="col-sm-10">
                  <input type="password" class="form-control" id="inputPass" />
                </div>
              </div>
              <fieldset>
                <div class="row mb-3">
                  <legend class="col-from-label col-sm-2">radio</legend>
                  <div class="col-sm-10">
                    <div class="form-check">
                      <input
                        type="radio"
                        class="form-check-input"
                        name="radios"
                        value="option1"
                        id="radios1"
                        checked
                      />
                      <label for="radios1" class="form-check-label">Radio 1</label>
                    </div>
                    <div class="form-check">
                      <input
                        type="radio"
                        class="form-check-input"
                        name="radios"
                        value="option1"
                        id="radios2"
                      />
                      <label for="radios2" class="form-check-label">Radio 1</label>
                    </div>
                    <div class="form-check">
                      <input
                        type="radio"
                        class="form-check-input"
                        name="radios"
                        value="option1"
                        id="radios3"
                        disabled
                      />
                      <label for="radios3" class="form-check-label">Radio 1</label>
                    </div>
                  </div>
                </div>
                <div class="row mb-3">
                  <div class="col-form-label col-sm-2">Запомнить пароль?</div>
                  <div class="col-sm-10">
                    <div class="form-check">
                      <input type="checkbox" id="gridcheck" class="form-check-input" />
                      <label for="gridcheck" class="form-check-label"> save password</label>
                    </div>
                  </div>
                </div>
              </fieldset>
            </form>
          </div>
          <div class="modal-footer">
            <button class="btn btn-secondary">Сохранить изменения</button>
            <button class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
          </div>
        </div>
      </div>
    </div>
    <!-- MODAL -->
    <!-- <div class="modal" tabindex="-1">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Modal title</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
          <p>Modal body text goes here.</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <button type="button" class="btn btn-primary">Save changes</button>
        </div>
      </div>
    </div>
  </div>
   -->

    <!-- carousel -->

    <div class="container-fluid my-carousel">
      <div
        id="carouselExampleIndicators"
        class="carousel slide carousel-fade"
        data-bs-ride="carousel"
        data-bs-interval="5000"
      >
        <div class="carousel-indicators">
          <button
            type="button"
            data-bs-target="#carouselExampleIndicators"
            data-bs-slide-to="0"
            class="active"
            aria-current="true"
            aria-label="Slide 1"
          ></button>
          <button
            type="button"
            data-bs-target="#carouselExampleIndicators"
            data-bs-slide-to="1"
            aria-label="Slide 2"
          ></button>
          <button
            type="button"
            data-bs-target="#carouselExampleIndicators"
            data-bs-slide-to="2"
            aria-label="Slide 3"
          ></button>
        </div>
        <div class="carousel-inner">
          <div class="carousel-item active">
            <img src="@/assets/stock1.jpg" class="d-block w-100" alt="..." />
          </div>
          <div class="carousel-item">
            <img src="@/assets/stock3.jpg" class="d-block w-100" alt="..." />
          </div>
          <div class="carousel-item">
            <img src="@/assets/stock4.jpg" class="d-block w-100" alt="..." />
          </div>
        </div>
        <button
          class="carousel-control-prev"
          type="button"
          data-bs-target="#carouselExampleIndicators"
          data-bs-slide="prev"
        >
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </button>
        <button
          class="carousel-control-next"
          type="button"
          data-bs-target="#carouselExampleIndicators"
          data-bs-slide="next"
        >
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </button>
      </div>
    </div>
    <section class="main-content">
      <!-- счетчик -->
      <div class="container-md">
        <div class="row">
          <!-- col-lg-6 col-sm-6 -->
          <div class="col-lg-12 col-sm-12 mb-3">
            <div class="product-card">
              <!-- наполнение карточки -->
              <h5 class="card-header">Card</h5>
              <div class="card-body">
                <div class="counter">
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Architecto recusandae
                  temporibus ea dolore nam inventore optio, reprehenderit in quo nihil dolorem
                  expedita sint iusto voluptates eos eius. Aut debitis laboriosam maiores. Delectus
                  numquam, maxime eaque inventore laboriosam, laborum, temporibus quaerat blanditiis
                  id nobis quisquam ad molestias. Rem repellendus eos impedit!
                  <br />
                  Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rem culpa est quod quae
                  accusantium, hic minima tempora consequuntur inventore quos animi, illum numquam
                  vel sunt modi ipsum distinctio totam. Accusamus, totam iure inventore non ex nisi!
                  Id voluptatibus aliquid nesciunt, tenetur aut cum corporis magnam totam natus?
                  Libero dolorum ut odit sit necessitatibus adipisci minima, veniam repellat aut
                  alias aperiam voluptates laudantium tempora dolore sequi ea inventore cupiditate
                  perspiciatis delectus, optio doloribus temporibus iste.
                  <br />Reiciendis dolor consequuntur earum asperiores expedita inventore iste
                  deserunt, sequi, iusto ipsum veritatis tempore quis accusamus necessitatibus vitae
                  dolores placeat aut ex nobis esse? Reiciendis, quos.
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="container-md my-5">
          <div class="row">
            <div class="col-lg-8 tets2">
              <h2>колонка на 8 роу col 8</h2>
              Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ullam deleniti ipsum animi
              voluptatem corrupti placeat perferendis est quasi quibusdam eos..
            </div>
            <div class="col-lg-4">
              <h2>колонка на 4 роу col 4</h2>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut esse illum quas ad
              mollitia tempore, voluptatem vitae nemo neque delectus?
            </div>
          </div>
          <div class="row">
            <div class="col-md-12">
              <h1>exaple text</h1>
            </div>
            <div class="col-md-12"><h1>exaple text</h1></div>
            <div class="col-md-12"><h1>exaple text</h1></div>
          </div>
        </div>
      </div>
      <div class="container text-center">
        <h1>Горизонтальная карусель</h1>
        <p>
          <a
            href="#multiCollapse1"
            data-bs-toggle="collapse"
            aria-controls="multiCollapse1"
            role="button"
            aria-expanded="false"
            class="btn btn-secondary m-2"
            >Улица</a
          >
          <button
            class="btn btn-secondary"
            type="button"
            data-bs-target="#multiCollapse2"
            aria-expanded="false"
            aria-controls="multiCollapse2"
            data-bs-toggle="collapse"
          >
            Абстракция
          </button>
          <button
            class="btn btn-secondary m-2"
            type="button"
            data-bs-target=".multi-collapse"
            aria-expanded="false"
            aria-controls="multiCollapse1 multiCollapse2"
            data-bs-toggle="collapse"
          >
            Улица | абстракция
          </button>
        </p>

        <div class="row">
          <div class="col">
            <div class="collapse multi-collapse show" id="multiCollapse1">
              <div class="card card-body">
                <img src="@/assets/wgtbls.jpeg" alt="" class="w-100" />
              </div>
            </div>
          </div>
          <div class="col">
            <div class="collapse multi-collapse show" id="multiCollapse2">
              <div class="card card-body">
                <img src="@/assets/witrine.jpeg" alt="" class="w-100" />
              </div>
            </div>
          </div>
          <div class="col">
            <div class="collapse multi-collapse show" id="multiCollapse1">
              <div class="card card-body">
                <img src="@/assets/chair.jpeg" alt="" class="w-100" />
              </div>
            </div>
          </div>
          <div class="col">
            <div class="collapse multi-collapse show" id="multiCollapse2">
              <div class="card card-body">
                <img src="@/assets/woman.jpeg" alt="" class="w-100" />
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="container">
        <!-- <div class="d-md-flex"> -->

        <div class="d-md-flex justify-content-around">
          <div class="p-5">1</div>
          <div class="p-5">2</div>
          <div class="p-5">3</div>
        </div>
      </div>
    </section>
    <!-- скрипт бустрапа -->
  </div>
</template>

<script>
export default {
  name: "viewbody",
  props: {},
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
.navbar {
  background-color: none;
  background: rgba(245, 245, 245, 0.75);
  transition: background-color 0.2s ease-in-out;
  backdrop-filter: blur(20px);
}
/* h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
} */
</style>
