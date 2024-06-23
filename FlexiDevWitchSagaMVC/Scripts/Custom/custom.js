$(document).ready(function () {
    var personIndex = $('#people .person').length;

    function addPerson() {
        var personHtml = `
            <hr>
            <div class="person">
                <h5 class="card-title">Person ${personIndex + 1}</h5>
                 <div class="form-group row" style="margin:10px 0px;">
                    <label for="inputAoD" class="col-sm-4 col-form-label">Age of Death</label>
                    <div class="col-sm-8">
                        <input class="form-control" name="[${personIndex}].AgeOfDeath" type="text" />
                    </div>
                 </div>

                 <div class="form-group row" style="margin:10px 0px;">
                    <label for="inputYoD" class="col-sm-4 col-form-label">Year of Death</label>
                    <div class="col-sm-8">
                        <input class="form-control" name="[${personIndex}].YearOfDeath" type="text" />
                    </div>
                 </div>
            </div>`;
        $('#people').append(personHtml);
        personIndex++;
    }

    $('#addPersonButton').click(function () {
        addPerson();
    });
});
