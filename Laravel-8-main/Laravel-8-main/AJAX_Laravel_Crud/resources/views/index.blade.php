<!DOCTYPE html>
<html>
    <head>

        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="csrf-token" content="{{ csrf_token() }}">
        <title>Ajax CRUD</title>

        {{-- Bootstrap CDN --}}
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        
        {{-- Data Table CDN --}}
        <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs5/dt-1.12.1/datatables.min.css"/>

        {{-- Bootstrap Icon CDN --}}
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">


        
    </head>
    <body class="antialiased">

{{-- add new employee modal start --}}
    <div class="modal fade" id="addTagModal" tabindex="-1" aria-labelledby="exampleModalLabel" data-bs-backdrop="static" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Add New Employee</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
            
                <form action="#" method="POST" id="add_tag_form" enctype="multipart/form-data">
                    @csrf
                    <div class="modal-body p-4 bg-light">
                
                        <div class="my-2">
                            <label for="name">Tag name</label>
                            <input type="name" name="name" class="form-control" placeholder="Tag Name" required>
                        </div>
                        
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                            <button type="submit" id="add_tag_btn" class="btn btn-primary">Add Tag</button>
                        </div>
                    </div>    
                </form>
            </div>
        </div>
    </div>
{{-- add new tag modal end --}}

      
{{-- edit tag modal start --}}
    <div class="modal fade" id="editTagModal" tabindex="-1" aria-labelledby="exampleModalLabel" data-bs-backdrop="static" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Edit Tag</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
            
                <form action="#" method="POST" id="edit_tag_form" enctype="multipart/form-data">
                    @csrf
                
                    <div class="modal-body p-4 bg-light">
                        <div class="my-2">
                            <label for="name">Tag Name</label>
                            <input type="text" name="name" id="name" class="form-control" placeholder="Tag Name" required>
                            <input type="hidden" name="id" id="tag_id" class="form-control">
                        </div>
                    </div>
              
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                        <button type="submit" id="edit_tag_btn" class="btn btn-success">Update Tag</button>
                    </div>
                </form>
            </div>
        </div>
    </div>


{{-- edit tag modal end --}}
      
    
    <body class="bg-light">
        
        <div class="container">
            <div class="row my-5">
                <div class="col-lg-12">
                    <div class="card shadow">
                        <div class="card-header bg-danger d-flex justify-content-between align-items-center">
                            <h3 class="text-light">View Tags</h3>
                            <button class="btn btn-light" data-bs-toggle="modal" data-bs-target="#addTagModal"><i class="bi-plus-circle me-2"></i>Add New Tag</button>
                        </div>
                        <div class="card-body" id="show_all_employees">
                            <h1 class="text-center text-secondary my-5">Loading...</h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        {{-- JQuery CDN --}}
        <script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
        
        {{-- Bootstrap CDN Bundle --}}
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        
        {{-- Data Table CDN --}}
        <script type="text/javascript" src="https://cdn.datatables.net/v/bs5/dt-1.12.1/datatables.min.js"></script>
        
        {{-- Sweet Alert CDN --}}
        <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>

        <script>

            //Add New Tag
            $('#add_tag_form').submit(function(e){
                e.preventDefault();
                $.ajaxSetup({
                    headers:{
                        'X-CSRF-TOKEN': $('meta[name="csrf-token"]').attr('content')
                    }    
                });
                const fd = new FormData(this);
                console.log(fd);
                $('#add_tag_btn').text('Adding...');
                $.ajax({
                    url: "{{url('/store')}}",
                    type: 'post',
                    data: fd,
                    cache: false,
                    contentType: false,
                    processData: false,
                    dataType: 'json',

                    success: function(response) {
                        console.log(response);
                        if (response.status == 200) {
                            Swal.fire(
                                'Added!',
                                'Tag Added Successfully!',
                                'success'
                            )
                            fetchAllEmployees();
                        }
                        $("#add_tag_btn").text('Add Tag');
                        $("#add_tag_btn")[0].reset();
                        $("#addTagModal").modal('hide');
                    }
                });    
            });

            function fetchAllEmployees() {
                $.ajax({
                    url: '{{ route('fetchAll') }}',
                    method: 'get',
                    success: function(response) {
                        $("#show_all_employees").html(response);
                        $("table").DataTable({
                            order: [0, 'desc']
                        });
                    }
                });
            }

            //Delete
            $(document).on('click', '.deleteIcon', function(e) {
                e.preventDefault();
                let id = $(this).attr('id');
                let csrf = '{{ csrf_token() }}';
                Swal.fire({
                    title: 'Are you sure?',
                    text: "You won't be able to revert this!",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, delete it!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            url: '{{ route('delete') }}',
                            method: 'delete',
                            data: {
                                id: id,
                                _token: csrf
                            },
                            success: function(response) {
                                console.log(response);
                                Swal.fire(
                                    'Deleted!',
                                    'Your file has been deleted.',
                                    'success'
                                )
                                fetchAllEmployees();
                            }
                        });
                    }
                });
            });

            // Edit
            $(document).on('click', '.editIcon', function(e) {
                e.preventDefault();
                let id = $(this).attr('id');
                $.ajax({
                    url: '{{ route('edit') }}',
                    method: 'get',
                    data: {
                        id: id,
                        _token: '{{ csrf_token() }}'
                    },
                    success: function(response) {
                        console.log(response);
                        $("#name").val(response.name);
                        $("#tag_id").val(response.id);
                    }
                });
            });

             // update
            $("#edit_tag_form").submit(function(e) {
            
                e.preventDefault();
        
                $("#edit_tag_btn").text('Updating...');
                $.ajax({
                    url: '{{ route('update') }}',
                    method: 'POST',
                    data: { 
                        id: $('#tag_id').val(),
                        name: $('#name').val(),
                    } ,
                    success: function(response) {
                        console.log(response);



                        if (response.status == 200) {
                            Swal.fire(
                                'Updated!',
                                'TAG Updated Successfully!',
                                'success'
                            )
                            fetchAllEmployees();
                        }
                        $("#edit_tag_btn").text('Update Tag');
                        $("#edit_tag_form")[0].reset();
                        $("#editTagModal").modal('hide');
                    }
                });
            });


        
        </script>

    </body>
</html>
